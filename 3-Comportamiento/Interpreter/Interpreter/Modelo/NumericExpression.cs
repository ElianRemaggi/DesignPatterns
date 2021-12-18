
namespace Modelo
{
    public class NumericExpression : IExpression
    {
        private string _value;

        public NumericExpression(string token)
        {
            this._value = token;
        }

        public void interpreter(Context context)
        {
            context.setOperator(context.getInteger(_value));
            context.calculate();
        }
    }
}
