using ProtetorDigital.Services;

namespace ProtetorDigital
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new FrmMenu());
            }
            catch (Exception ex)
            {
                ExibirErro(RegistroErros.Registrar(ex, "Inicialização ou execução principal"));
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ExibirErro(RegistroErros.Registrar(e.Exception, "Thread da interface Windows Forms"));
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception excecao)
            {
                RegistroErros.Registrar(excecao, "Exceção não tratada do AppDomain");
            }
        }

        private static void TaskScheduler_UnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
        {
            RegistroErros.Registrar(e.Exception, "Task não observada");
            e.SetObserved();
        }

        private static void ExibirErro(string? caminho)
        {
            var mensagem = caminho is null
                ? "Ocorreu um erro durante a execução, mas não foi possível salvar o relatório."
                : $"Ocorreu um erro durante a execução. Relatório salvo em:{Environment.NewLine}{caminho}";
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
