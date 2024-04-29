namespace Calculator.Domain.ValueObjects
{
    /// <summary>
    /// 計算用の値
    /// </summary>
    public class CalculationValue : ValueObject<CalculationValue>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value"></param>
        public CalculationValue(string value)
        {
            Value = value; ;
        }

        /// <summary>
        /// 計算用の値（文字列）
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// 正常な値（文字列）。小数点ポイントを省くなど、正常な表示に変換される。
        /// </summary>
        public string NormalValue => Convert.ToSingle(Value).ToString();

        /// <summary>
        /// 計算用の値（小数）
        /// </summary>
        public double ValueDouble => Convert.ToSingle(Value);

        /// <summary>
        /// 同値であればtrue
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected override bool EqualsCore(CalculationValue other)
        {
            return Value == other.Value;
        }

        /// <summary>
        /// HashCodeを返す
        /// </summary>
        /// <returns></returns>
        protected override int GetHashCodeCore()
        {
            if (Value == null)
            {
                return 0;
            }

            return Value.GetHashCode();
        }
    }
}
