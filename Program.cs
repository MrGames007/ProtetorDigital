using ProtetorDigital.Services;

namespace ProtetorDigital
{
    internal static class Program
    {
        // Ponto de entrada do Protetor Digital: configura a captura de falhas antes de abrir o menu principal.
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Os três eventos cobrem falhas da UI, do AppDomain e de tarefas assíncronas não observadas.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            try
            {
                // Inicializa o Windows Forms e mantém o FrmMenu como janela principal da aplicação.
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
            // Erros ocorridos em eventos de controles são registrados e apresentados ao usuário.
            ExibirErro(RegistroErros.Registrar(e.Exception, "Thread da interface Windows Forms"));
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Captura exceções que escaparam do ciclo normal de mensagens da aplicação.
            if (e.ExceptionObject is Exception excecao)
            {
                RegistroErros.Registrar(excecao, "Exceção não tratada do AppDomain");
            }
        }

        private static void TaskScheduler_UnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
        {
            // Registra falhas de tarefas e marca a exceção como observada para evitar nova propagação.
            RegistroErros.Registrar(e.Exception, "Task não observada");
            e.SetObserved();
        }

        private static void ExibirErro(string? caminho)
        {
            // Informa onde o relatório foi salvo; se o registro falhar, comunica essa limitação claramente.
            var mensagem = caminho is null
                ? "Ocorreu um erro durante a execução, mas não foi possível salvar o relatório."
                : $"Ocorreu um erro durante a execução. Relatório salvo em:{Environment.NewLine}{caminho}";
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
