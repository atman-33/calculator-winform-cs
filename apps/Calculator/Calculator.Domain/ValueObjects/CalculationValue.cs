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
        /// 計算用の値（小数）
        /// </summary>
        public float ValueFloat => Convert.ToSingle(Value);

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
