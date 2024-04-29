using Calculator.Domain.ValueObjects;

namespace Calculator.Domain.Services
{
    /// <summary>
    /// 計算サービス
    /// </summary>
    internal class CalculateService
    {
        /// <summary>
        /// 四捨五入する小数点桁数
        /// </summary>
        const int DecimalPoint = 5;

        /// <summary>
        /// Value1 と Value2 の計算結果を返す
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        internal string Calculate(CalculationValue value1, CalculationValue value2, OperatorValue @operator)
        {
            if (@operator == OperatorValue.Add)
            {
                var result = value1.ValueDouble + value2.ValueDouble;
                result = Math.Round(result, DecimalPoint);
                return result.ToString();
            }

            if (@operator == OperatorValue.Subtract)
            {
                var result = value1.ValueDouble - value2.ValueDouble;
                result = Math.Round(result, DecimalPoint);
                return result.ToString();
            }

            if (@operator == OperatorValue.Multiply)
            {
                var result = value1.ValueDouble * value2.ValueDouble;
                result = Math.Round(result, DecimalPoint);
                return result.ToString();
            }

            if (@operator == OperatorValue.Divide)
            {
                // TODO: value2 が 0 の場合の対策を追加する必要あり
                var result = value1.ValueDouble / value2.ValueDouble;
                result = Math.Round(result, DecimalPoint);
                return result.ToString();
            }

            throw new Exception("演算記号が正しくありません!コードを見直して下さい。");
        }
    }
}
