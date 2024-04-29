using Calculator.Domain.Services;
using Calculator.Domain.ValueObjects;

namespace Calculator.Domain.Entities
{
    /// <summary>
    /// 計算過程、結果を格納する計算結果エンティティ
    /// </summary>
    public class CalculationResultEntity
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CalculationResultEntity()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="prev">前回の計算結果エンティティ</param>
        public CalculationResultEntity(CalculationResultEntity prev)
        {
            if (prev.Value1 is not null)
            {
                Value1 = new CalculationValue(prev.Value1.Value);
            }

            if (prev.Operator is not null)
            {
                Operator = new OperatorValue(prev.Operator.Value);
            }

            if (prev.Value2 is not null)
            {
                Value2 = new CalculationValue(prev.Value2.Value);
            }

            HasEqual = prev.HasEqual;
        }

        /// <summary>
        /// 一つ目の計算用の値
        /// </summary>
        public CalculationValue? Value1 { get; private set; } = null;

        /// <summary>
        /// 演算記号
        /// </summary>
        public OperatorValue? Operator { get; } = null;

        /// <summary>
        /// 二つ目の計算用の値
        /// </summary>
        public CalculationValue? Value2 { get; private set; } = null;

        /// <summary>
        /// =をインプットされた時はtrue
        /// </summary>
        public bool HasEqual { get; } = false;

        /// <summary>
        /// 計算過程
        /// </summary>
        public string Process
        {
            get
            {
                var str = HasEqual
                       ? $"{Value1?.NormalValue} {Operator?.Value} {Value2?.NormalValue} ="
                       : $"{Value1?.NormalValue} {Operator?.Value}";

                return str.Trim();
            }
        }

        /// <summary>
        /// 計算結果、もしくは入力中の値
        /// </summary>
        public string DisplayValue
        {
            get
            {
                var service = new CalculateService();
                if (HasEqual && Value1 is not null && Value2 is not null && Operator is not null)
                {
                    return service.Calculate(Value1, Value2, Operator);
                }

                if (Value2 is not null)
                {
                    return Value2.Value;
                }

                if (Value1 is not null)
                {
                    return Value1.Value;
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// 前回のエンティティ
        /// </summary>
        public CalculationResultEntity? PrevEntity { get; set; } = null;

        /// <summary>
        /// 次のエンティティ
        /// </summary>
        public CalculationResultEntity? NextEntity { get; set; } = null;

        /// <summary>
        /// 数値を追加する。
        /// - 演算記号無し => Value1に追加
        /// - 演算記号有り => Value2に追加
        /// </summary>
        /// <param name="num"></param>
        public void SetNumber(int num)
        {
            if (Operator is null)
            {
                if (Value1 is null || Value1?.ValueFloat == 0)
                {
                    Value1 = new CalculationValue(num.ToString());
                }
                else
                {
                    Value1 = new CalculationValue(Value1?.Value + num.ToString());
                }
            }
            else
            {
                if (Value2 is null || Value2?.ValueFloat == 0)
                {
                    Value2 = new CalculationValue(num.ToString());
                }
                else
                {
                    Value2 = new CalculationValue(Value2?.Value + num.ToString());
                }
            }
        }

        /// <summary>
        /// 小数点を追加できる時はtrue
        /// </summary>
        /// <returns></returns>
        public bool CanAddPoint()
        {
            if (Operator is null)
            {
                if (Value1 is null || Value1?.ValueFloat == 0)
                {
                    return true;
                }
                else
                {
                    return Value1 is null ? true : !Value1.Value.Contains(".");
                }
            }
            else
            {
                if (Value2 is null || Value2?.ValueFloat == 0)
                {
                    return true;
                }
                else
                {
                    return Value2 is null ? true : !Value2.Value.Contains(".");
                }
            }
        }

        /// <summary>
        /// 小数点を追加する。
        /// </summary>
        public void SetPoint()
        {
            if (Operator is null)
            {
                if (Value1 is null || Value1?.ValueFloat == 0)
                {
                    Value1 = new CalculationValue("0.0");
                }
                else
                {
                    Value1 = new CalculationValue(Value1?.Value + ".");
                }
            }
            else
            {
                if (Value2 is null || Value2?.ValueFloat == 0)
                {
                    Value2 = new CalculationValue("0.0");
                }
                else
                {
                    Value2 = new CalculationValue(Value2?.Value + ".");
                }
            }
        }
    }
}
