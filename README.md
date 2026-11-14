# Protetor Digital

## Identificação da aplicação

- **Nome:** Protetor Digital.
- **Versão:** não definida no arquivo de projeto; aplicação em desenvolvimento.
- **Objetivo:** oferecer conteúdo educativo sobre prevenção de golpes digitais, incluindo dicas, exemplos de golpes, relatos e quiz interativo.
- **Tipo:** aplicação desktop Windows Forms.
- **Sistema operacional compatível:** Windows com suporte ao .NET 10 para Windows.
- **Arquitetura publicada:** Windows x64, conforme o perfil de publicação disponível.
- **Framework utilizado:** .NET 10 (`net10.0-windows`) com Windows Forms.

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

Para gerar uma publicação de Release usando o perfil configurado:

```powershell
dotnet publish -c Release -p:PublishProfile=Windows
```

Os arquivos publicados ficam no diretório de saída definido pelo perfil de publicação. A aplicação requer que as pastas `dados/` e `imagens/` acompanhem a publicação.

## Dependências necessárias

- .NET 10 SDK para compilar e publicar.
- .NET 10 Runtime para executar uma publicação dependente do framework.
- Windows Forms, incluído no SDK/runtime do .NET para Windows.
- Não há pacotes NuGet adicionais declarados no projeto.

## Localização dos arquivos usados pela aplicação

- `dados/creditos.json`: créditos e informações institucionais.
- `dados/dicas.json`: dicas educativas.
- `dados/exgolpes.json`: exemplos de golpes.
- `dados/perguntas.json`: perguntas do quiz.
- `dados/relatos.json`: relatos e metadados das matérias.
- `imagens/`: imagens usadas pela interface.

Durante a publicação, os arquivos de `dados/` e `imagens/` são copiados para a saída com `PreserveNewest`. O carregamento também possui fallback para a estrutura de desenvolvimento quando aplicável.

## Banco de dados

A aplicação não utiliza banco de dados. Não há servidor, conexão, credenciais, migrações, procedimentos de instalação, importação ou restauração de banco de dados.

O conteúdo é mantido em arquivos JSON externos, que podem ser editados sem modificar a lógica das telas, desde que o formato e os nomes das propriedades sejam preservados.

## Edição e configuração do conteúdo

Edite os arquivos `dados/*.json` mantendo seus formatos e propriedades. Os créditos ficam em `dados/creditos.json`; alterações de conteúdo não exigem recompilação da lógica, mas os arquivos precisam estar disponíveis na pasta da aplicação.

Não há arquivo de configuração de conexão porque não existe banco de dados. Configurações de compilação e publicação ficam em `ProtetorDigital.csproj` e nos perfis de publicação.

## Solução de problemas comuns

- **A aplicação não inicia:** confirme que o Windows e o .NET 10 estão instalados ou use uma publicação autocontida.
- **Conteúdo não aparece:** verifique se as pastas `dados/` e os arquivos JSON foram copiados para o diretório da aplicação.
- **Imagens ausentes:** confirme se a pasta `imagens/` acompanha o executável.
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