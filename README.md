# Protetor Digital

Aplicação Windows Forms em .NET 10 para educação sobre prevenção de golpes digitais.

## Estrutura

- `Forms/`: telas da aplicação.
- `Models/`: modelos dos dados.
- `Services/`: serviços de conteúdo, janelas e responsividade.
- `dados/`: arquivos JSON de perguntas, dicas, golpes, relatos e créditos.
- `imagens/`: imagens usadas pela interface.

## Editar conteúdo

Edite os arquivos `dados/*.json` mantendo seus formatos e propriedades. Os créditos ficam em `dados/creditos.json`; alterações de conteúdo não exigem modificar a lógica das telas.

## Publicar

```powershell
dotnet publish -c Release -p:PublishProfile=Windows
```
