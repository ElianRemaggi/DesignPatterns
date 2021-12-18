
namespace Modelo
{
    public class OperatorExpression : IExpression
    {
        private string _operation;

        public OperatorExpression(string token)
        {
            this._operation = token;
        }

        public void interpreter(Context context)
        {
            context.setOperation(_operation);
        }
    }
}
