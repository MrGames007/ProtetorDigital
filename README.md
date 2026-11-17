# Protetor Digital

## Identificação da aplicação

- **Nome:** Protetor Digital.
- **Versão:** não definida no arquivo de projeto; aplicação em desenvolvimento.
- **Objetivo:** oferecer conteúdo educativo sobre prevenção de golpes digitais, incluindo dicas, exemplos de golpes, relatos e quiz interativo.
- **Tipo:** aplicação desktop Windows Forms.
- **Sistema operacional compatível:** Windows com suporte ao .NET 10 para Windows.
- **Arquitetura publicada:** Windows x64, conforme o perfil de publicação disponível.
- **Framework utilizado:** .NET 10 (`net10.0-windows10.0.17763.0`) com Windows Forms.

## Requisitos mínimos

- Windows compatível com o .NET 10 para Windows.
- Runtime ou SDK do .NET 10 instalado, conforme a forma de execução.
- Permissão de leitura na pasta da aplicação.
- Para publicação autocontida, o runtime não precisa ser instalado separadamente.

## Instruções de execução

Na raiz do projeto, execute:

```powershell
dotnet run --project .\ProtetorDigital.csproj
```

Também é possível abrir `ProtetorDigital.slnx` no Visual Studio e executar o projeto `ProtetorDigital`.

## Publicação

Para gerar uma publicação de Release autocontida, single-file e Windows x64:

```powershell
dotnet publish .\ProtetorDigital.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:EnableCompressionInSingleFile=true -p:DebugType=None -p:DebugSymbols=false -o executavel
```

O arquivo gerado é `executavel/ProtetorDigital.exe`. O repositório não contém um perfil `Windows.pubxml`; a publicação é feita diretamente pelo comando acima.

Os JSONs de `dados/` e as duas logos usadas nos Créditos ficam embutidos no executável publicado. Arquivos externos ao lado do executável têm prioridade, permitindo editar o conteúdo sem recompilar; a publicação single-file não precisa das pastas `dados/` e `imagens/`.

## Dependências necessárias

- .NET 10 SDK para compilar e publicar.
- .NET 10 Runtime somente para execução dependente do framework; a publicação autocontida não exige runtime instalado.
- Windows Forms, incluído no SDK/runtime do .NET para Windows.
- Não há pacotes NuGet adicionais declarados no projeto.

## Localização dos arquivos usados pela aplicação

- `dados/creditos.json`: créditos e informações institucionais.
- `dados/dicas.json`: dicas educativas.
- `dados/exgolpes.json`: exemplos de golpes.
- `dados/perguntas.json`: perguntas do quiz.
- `dados/relatos.json`: relatos e metadados das matérias.
- `imagens/`: imagens usadas pela interface.

As respostas corretas do quiz estão distribuídas entre as quatro posições das alternativas. A tela ainda embaralha as opções em memória com `Random.Shared.Shuffle`, preservando a associação entre alternativa e resposta correta.

Durante o desenvolvimento, os arquivos de `dados/` e `imagens/` continuam sendo copiados para a saída com `PreserveNewest`. Em execução, o aplicativo procura primeiro esses arquivos externos e depois usa os recursos embutidos.

## Banco de dados

A aplicação não utiliza banco de dados. Não há servidor, conexão, credenciais, migrações, procedimentos de instalação, importação ou restauração de banco de dados.

O conteúdo é mantido nos JSONs do projeto e também embutido no executável. Uma pasta `dados/` ao lado do executável tem prioridade e permite editar o conteúdo sem recompilar. Para alterar o conteúdo embutido, edite `dados/*.json` no projeto e publique novamente.

## Edição e configuração do conteúdo

Edite os arquivos `dados/*.json` mantendo seus formatos e propriedades. Os créditos ficam em `dados/creditos.json`; alterações podem ser usadas imediatamente colocando a pasta `dados/` ao lado do executável, ou podem ser embutidas publicando novamente o projeto.

Não há arquivo de configuração de conexão porque não existe banco de dados. Configurações de compilação e publicação ficam em `ProtetorDigital.csproj` e nos perfis de publicação.

## Solução de problemas comuns

- **A aplicação não inicia:** confirme que o Windows e o .NET 10 estão instalados ou use uma publicação autocontida.
- **Conteúdo não aparece:** verifique a sintaxe do JSON externo; sem ele, o executável usa o conteúdo embutido.
- **Imagens ausentes:** confirme o nome da logo; as duas logos dos Créditos são embutidas no executável.
- **Erro após editar JSON:** valide a sintaxe JSON e mantenha os nomes das propriedades esperados pelos modelos.
- **Falha ao compilar:** execute `dotnet restore` e depois `dotnet build` na raiz do projeto; confira se o SDK do .NET 10 está disponível.

## Estrutura principal

- `Forms/`: telas da aplicação.
- `Models/`: modelos dos dados.
- `Services/`: serviços de conteúdo, janelas, responsividade e largura de textos.
- `dados/`: arquivos JSON de perguntas, dicas, golpes, relatos e créditos.
- `imagens/`: imagens usadas pela interface.
- `Erros/`: relatórios `.txt` gerados automaticamente para exceções durante a execução.
- `docs/CODIGO/`: documentação técnica dos arquivos e componentes.
- `DOCUMENTACAO_PROJETO.txt`: documentação de manutenção e histórico das alterações.