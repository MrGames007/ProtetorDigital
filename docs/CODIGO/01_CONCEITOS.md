# 01 — Conceitos que aparecem no projeto

Cada item traz uma analogia curta, um exemplo real e o arquivo/linha para conferência.

## 🟢 Básico

### Programa, código-fonte e compilação

- **Programa:** conjunto de instruções executadas pelo computador. Analogia: uma receita completa.
- **Código-fonte:** texto escrito pela equipe antes de virar programa. Analogia: a receita no papel.
- **Compilar:** transformar esse texto em arquivos que o sistema consegue executar. Analogia: preparar os ingredientes e assar a receita.
- **Exemplo:** `Program.cs`, linhas 9–14, contém o ponto de entrada e inicia a janela.

### Projeto e solução

Um **projeto** reúne código, dados e configurações de uma aplicação. O arquivo `ProtetorDigital.csproj`, linhas 1–40, descreve o projeto e define `net10.0-windows`. Uma **solução** organiza um ou mais projetos; aqui ela é `ProtetorDigital.slnx`.

### Namespace e using

**Namespace** é um sobrenome para agrupar tipos e evitar nomes iguais. Analogia: uma cidade separa pessoas com o mesmo nome. `Models/Dica.cs`, linha 4, usa `namespace ProtetorDigital`. `using` permite usar um namespace sem repetir seu nome: `Models/Dica.cs`, linhas 1–2.

### Classe e objeto

Uma **classe** é um molde; um **objeto** é algo criado a partir dele, como molde de bolo e bolo. `Models/Dica.cs`, linhas 6–16, define o molde `Dica`. `Program.cs`, linha 14, cria um objeto `FrmMenu` com `new`.

### Variáveis e tipos

Variável é uma caixa com nome. O tipo diz o que cabe nela:

- `int`: número inteiro, como `Models/Dica.cs`, linha 8 (`Id`).
- `string`: texto, como `Models/Dica.cs`, linha 10 (`Titulo`).
- `bool`: verdadeiro/falso; `Forms/FrmQuiz.cs`, linha 129, cria `bool acertou`.
- `float`: número decimal; `Services/Responsivo.cs`, linhas 11 e 74, guarda a escala.

### Operadores

Operadores fazem contas e comparações. `Services/Responsivo.cs`, linhas 72–76, usa divisão, `Math.Min` e limite de escala. `Forms/FrmQuiz.cs`, linhas 121–125, compara `==` para verificar se nenhuma alternativa foi marcada.

### if e else

`if` escolhe um caminho quando uma condição é verdadeira; `else` cobre o outro caminho. Em `Services/ConteudoService.cs`, linhas 18–21, o método retorna quando o arquivo não foi encontrado.

### for e foreach

O projeto usa principalmente `foreach`, que visita cada item de uma coleção. Em `Services/Responsivo.cs`, linhas 29–33, ele remove os controles registrados. Também aparece em `Services/Responsivo.cs`, linhas 50–53 e 64–67, para visitar controles filhos. Não há um `for` tradicional no código atual.

### Métodos e parâmetros

Método é uma ação nomeada; parâmetro é a informação recebida pela ação. `ConteudoService.CarregarObjeto<T>` em `Services/ConteudoService.cs`, linha 15, recebe `nomeArquivo`. `Program.Main`, linha 9, não recebe parâmetros.

### Comentários

Comentário é uma anotação ignorada pelo compilador. `Program.cs`, linhas 5–7 e 11–12, documenta o ponto de entrada. Comentários não mudam o comportamento.

### List<T> e arrays

`List<T>` é uma lista que cresce; `T` informa o tipo dos itens. `Models/Pergunta.cs`, linha 13, usa `List<string>?` para alternativas. Não há arrays (`string[]`, por exemplo) no código-fonte atual.

## 🟡 Intermediário

### Propriedades get/set

Propriedade é uma porta de leitura e gravação de um objeto. Analogia: uma etiqueta com acesso controlado. `Models/Relato.cs`, linhas 7–19, declara propriedades com `get; set;`; o JSON pode preenchê-las.

### Campos privados

Campo guarda estado interno da classe. O prefixo `_` ajuda a reconhecê-lo. `Forms/FrmQuiz.cs`, linhas 16–20, guarda perguntas, índice, pontuação e resposta correta; outras classes não acessam diretamente esses campos.

### Construtores

Construtor prepara um objeto logo após `new`. `Forms/FrmMenu.cs`, linhas 7–61, configura a janela e seus controles. `Forms/FrmBiblioteca.cs`, linhas 15–59, recebe a janela de origem.

### Eventos e manipuladores

Evento é um aviso; manipulador é o método chamado quando o aviso ocorre. Analogia: campainha e pessoa que atende. Exemplos: `FrmQuiz.cs`, linhas 26–27, liga eventos; `Services/Responsivo.cs`, linhas 26–34, reage a `Resize` e `FormClosed`; `FrmCreditos.cs`, linhas 39–46, reage a `Click` e `KeyDown`.

### Windows Forms

Windows Forms é a biblioteca de janelas do projeto.

- `Form`: janela, em `Program.cs`, linha 14.
- `Button`: botão, em `Forms/FrmMenu.Designer.cs`, linhas 20–22.
- `Label`: texto de tela, em `Forms/FrmQuiz.Designer.cs`, linha 19.
- `Panel`: contêiner, em `Forms/FrmCreditos.cs`, linha 106.
- `TableLayoutPanel`: grade que distribui controles, em `Forms/FrmCreditos.cs`, linha 47.
- `FlowLayoutPanel`: contêiner que organiza itens em fluxo; aparece nos designers de dicas e golpes.
- `RadioButton`: opção de escolha, em `Forms/FrmQuiz.Designer.cs`, linhas 20–23.
- `PictureBox`: área para imagem, em `Forms/FrmCreditos.cs`, linha 171.

`RichTextBox` e `ProgressBar` não aparecem no código atual.

### Designer e InitializeComponent

O arquivo `.Designer.cs` guarda a criação visual feita pelo Visual Studio. `InitializeComponent`, por exemplo `Forms/FrmMenu.Designer.cs`, linha 17, cria e configura controles. Ele funciona como uma lista automática de montagem. Não deve ser editado manualmente sem necessidade.

### Dock, Anchor e MaximumSize

- `Dock` cola um controle a uma borda ou ocupa o contêiner; `FrmCreditos.cs`, linhas 51–52.
- `Anchor` mantém distância de bordas durante o redimensionamento; `FrmQuiz.Designer.cs`, linhas 116–117.
- `MaximumSize` limita o tamanho máximo; `FrmDicas.Designer.cs`, linhas 105–106.

### Modal e não modal

Uma janela **modal** bloqueia a janela anterior até fechar, como uma fila com atendimento único. `FrmMenu.cs`, linhas 15–19, usa `ShowDialog(this)` para Créditos. Uma janela não modal permite voltar à anterior enquanto continua aberta; `FrmMenu.cs`, linhas 65–71, usa `Show()` para Quiz e Biblioteca. A documentação anterior pode dizer que todas as telas filhas usam `ShowDialog`, mas o código atual não faz isso.

### MessageBox

`MessageBox` abre uma caixa de aviso. `Forms/FrmQuiz.cs`, linhas 123–125 e 150–152, informa seleção ausente ou resultado da resposta.

### Formatação de texto

Interpolação `$"..."` coloca valores dentro de uma string. `FrmQuiz.cs`, linhas 146–148, monta o feedback. `string.Format` não aparece no código atual.

### Tratamento de erros

`try` tenta executar; `catch` trata uma falha; `finally` executa a limpeza mesmo após erro. `Forms/FrmQuiz.cs`, linhas 32–70, usa `try/catch`. `Services/Responsivo.cs`, linhas 84–108, usa `try/finally`. `throw` não aparece no código atual.

### Leitura de arquivos e caminhos

`File` lê e testa arquivos; `Path` monta caminhos sem juntar barras manualmente. `Services/ConteudoService.cs`, linhas 23 e 29–37, faz isso. `AppDomain.CurrentDomain.BaseDirectory` aponta para a pasta de execução. `AppContext.BaseDirectory` e `%AppData%` não aparecem no código atual.

### JSON

JSON é texto estruturado para dados. `System.Text.Json` lê esse texto. `JsonSerializer.Deserialize<T>` converte JSON em objeto, usado em `ConteudoService.cs`, linha 24. `[JsonPropertyName]` liga um nome JSON a outro nome C#, como `Models/Relato.cs`, linhas 15–19. `JsonSerializerOptions` configura a leitura em `ConteudoService.cs`, linhas 8–13.

## 🔴 Avançado

### Nulos e operadores `?`, `??` e `!`

Com `Nullable` habilitado, `string?` avisa que o texto pode não existir; veja `Models/Relato.cs`, linha 9. `?.` acessa algo somente se não for nulo; `??` fornece alternativa, como `Services/ConteudoService.cs`, linha 43. O operador `!` não aparece no código atual.

### Generics

Generic é um molde que funciona com vários tipos. Analogia: uma caixa que recebe uma etiqueta dizendo o conteúdo. `CarregarObjeto<T>` em `ConteudoService.cs`, linha 15, pode retornar diferentes classes. `List<string>` é outro exemplo.

### LINQ

LINQ permite consultar coleções. `Forms/FrmQuiz.cs`, linhas 83–90, usa `Select` e `OrderBy`; `Any` aparece nas linhas 61 e 70. `Where` não aparece no código atual.

### Lambdas e delegates

Lambda é uma função curta sem nome; delegate é o tipo de referência para uma ação. `Services/Responsivo.cs`, linha 26, usa `(_, _) => Redimensionar(...)`. Eventos aceitam esse tipo de ação.

### Classes estáticas e serviços

Classe estática é uma caixa de ferramentas sem objeto próprio. `ConteudoService` e `Responsivo`, nas linhas 6 e 5 de seus arquivos, são estáticos. Eles separam tarefas reutilizáveis das telas.

### IDisposable, using e recursos GDI

`using` garante descarte de recursos. GDI é a parte do Windows que gerencia fontes e desenhos de tela. `Forms/FrmCreditos.cs`, linhas 177–180, carrega uma imagem dentro de `using`; `Responsivo.cs`, linhas 95–100, descarta a fonte anterior.

### Responsividade por escala de fontes

`Responsivo` calcula uma escala com base no tamanho da janela e recria fontes, sem mudar a fonte do formulário. O cálculo está em `Services/Responsivo.cs`, linhas 70–103. O limite é de 0,85 a 2,0 e o mínimo é 12 pontos.

### Separação de responsabilidades

O projeto separa modelos de dados em `Models`, janelas em `Forms` e utilitários em `Services`. É uma separação simples, parecida com uma escola que divide secretaria, salas e arquivo. O código não implementa MVC completo.

### Projeto e Git

`Nullable`, `ImplicitUsings`, `TargetFramework` e cópia de conteúdo aparecem em `ProtetorDigital.csproj`, linhas 3–40. Git registra versões; o commit consultado está no `00_INDICE.md`. Publicação autocontida e single-file não aparecem no projeto atual.

### Itens avançados que não existem

Não há `Tema.cs`, `HistoricoService.cs`, `ConteudoException`, `GraphicsPath`, `Random.Shared.Shuffle`, `CarregarLista<T>` ou arquivo `.pubxml` no código atual. Por isso eles não são explicados como se existissem.
