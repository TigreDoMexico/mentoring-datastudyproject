using BaseDeDados.Actions;
using BaseDeDados.UI;

namespace BaseDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainOperation = new UserAction();

            MainInterface.MostrarApresentacao();
            mainOperation.Begin();
        }
    }
}
