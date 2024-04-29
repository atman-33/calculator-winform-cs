namespace Calculator.Domain.ValueObjects
{
    /// <summary>
    /// 演算記号
    /// </summary>
    public class OperatorValue : ValueObject<OperatorValue>
    {
        /// <summary>
        /// +記号
        /// </summary>
        public static OperatorValue Add = new OperatorValue("+");

        /// <summary>
        /// -記号
        /// </summary>
        public static OperatorValue Subtract = new OperatorValue("-");

        /// <summary>
        /// ×記号
        /// </summary>
        public static OperatorValue Multiply = new OperatorValue("×");

        /// <summary>
        /// ÷記号
        /// </summary>
        public static OperatorValue Divide = new OperatorValue("÷");

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value"></param>
        public OperatorValue(string value)
        {
            Value = value;
        }

        /// <summary>
        /// 演算記号
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// 同値であればtrue
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>

        protected override bool EqualsCore(OperatorValue other)
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
