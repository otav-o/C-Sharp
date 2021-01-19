using System;
using System.Windows;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();

            p1.Update(true);
            p1.Start();
            
        }

        public event EventHandler OnSpacePressed; // evento. Inicialmente é null

        private void Start()
        {
            OnSpacePressed += Testing_OnSpacePressed; // função adicionada ao evento. Não possui parênteses no nome
            // assim que o evento for invocado (não pode ser nulo), a função que está presa a ele será executada também
        }

        private void Testing_OnSpacePressed(object sender, EventArgs e)
        {
            Console.WriteLine("Space!");
        }

        private void Update(bool y)
        {
            if (y)
            {
                //if(OnSpacePressed != null)
                //    OnSpacePressed(x, EventArgs.Empty); // chamar o evento como se fosse uma função

                OnSpacePressed?.Invoke(this, EventArgs.Empty); // o mesmo que o if acima
                // invoke é executar o evento
            }
        }
    }
}
