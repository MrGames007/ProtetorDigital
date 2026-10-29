# Como entender todo o código do ProtetorDigital

**Data da documentação:** 2026-10-28  
**Commit de referência:** `709f37212502cd7f8bbb3b5cad874964e91d2c30` (`709f372`, mensagem `.`)  
**Estado:** documentação baseada no conteúdo atual do diretório de trabalho. O repositório possui alterações locais; o commit acima é apenas a referência solicitada.

## Como usar este material

Leia nesta ordem: conceitos, visão geral, arquivos simples, serviços, telas, designers, projeto e dados. Depois use o glossário, as receitas e os exercícios. Os números de linha apontam para os arquivos reais lidos em 28/10/2026.

## Legenda

- 🟢 **Básico:** primeira ideia necessária para começar.
- 🟡 **Intermediário:** combina várias ideias básicas.
- 🔴 **Avançado:** exige compreender detalhes da plataforma ou do projeto.

## Inventário do projeto

### Código-fonte C#

- `Program.cs`
- `Models/CreditosInfo.cs`
- `Models/Dica.cs`
- `Models/ExGolpe.cs`
- `Models/Pergunta.cs`
- `Models/Relato.cs`
- `Properties/Resources.Designer.cs`
- `Services/ConteudoService.cs`
- `Services/Responsivo.cs`
- `Forms/FrmMenu.cs`
- `Forms/FrmBiblioteca.cs`
- `Forms/FrmDicas.cs`
- `Forms/FrmExGolpes.cs`
- `Forms/FrmRelatos.cs`
- `Forms/FrmCreditos.cs`
- `Forms/FrmQuiz.cs`
- `Forms/FrmMenu.Designer.cs`
- `Forms/FrmBiblioteca.Designer.cs`
- `Forms/FrmDicas.Designer.cs`
- `Forms/FrmExGolpes.Designer.cs`
- `Forms/FrmRelatos.Designer.cs`
- `Forms/FrmQuiz.Designer.cs`

### Dados e configuração

- `dados/creditos.json`
- `dados/dicas.json`
- `dados/exgolpes.json`
- `dados/perguntas.json`
- `dados/relatos.json`
- `ProtetorDigital.csproj`
- `ProtetorDigital.slnx`

### Recursos e documentação já existente

- `Forms/FrmBiblioteca.resx`
- `Forms/FrmDicas.resx`
- `Forms/FrmExGolpes.resx`
- `Forms/FrmMenu.resx`
- `Forms/FrmQuiz.resx`
- `Forms/FrmRelatos.resx`
- `Properties/Resources.resx`
- `imagens/idosos_felizes.jpg`
- `imagens/interrogacao.png`
- `imagens/livro.jpg`
- `imagens/livro.png`
- `DOCUMENTACAO_PROJETO.txt`
- `.gitattributes`
- `.gitignore`

Não foram encontrados arquivos `.pubxml` nem outros arquivos `.md` de documentação antes desta pasta. `bin`, `obj`, `.vs` e `.git` foram ignorados.

## Lista de verificação

- [x] `00_INDICE.md` — índice, inventário, commit e progresso
- [x] `01_CONCEITOS.md` — trilha de conceitos reais
- [x] `02_VISAO_GERAL.md` — mapa e fluxos
- [x] `10_Program.md`
- [x] `10_Models_CreditosInfo.md`
- [x] `10_Models_Dica.md`
- [x] `10_Models_ExGolpe.md`
- [x] `10_Models_Pergunta.md`
- [x] `10_Models_Relato.md`
- [ ] `10_Properties_Resources.md`
- [x] `10_Services_ConteudoService.md`
- [x] `10_Services_Responsivo.md`
- [x] `10_FrmMenu.md`
- [x] `10_FrmBiblioteca.md`
- [x] `10_FrmDicas.md`
- [x] `10_FrmExGolpes.md`
- [x] `10_FrmRelatos.md`
- [x] `10_FrmCreditos.md`
- [x] `10_FrmQuiz.md`
- [x] `10_FrmMenu_Designer.md`
- [x] `10_FrmBiblioteca_Designer.md`
- [x] `10_FrmDicas_Designer.md`
- [x] `10_FrmExGolpes_Designer.md`
- [x] `10_FrmRelatos_Designer.md`
- [x] `10_FrmQuiz_Designer.md`
- [ ] `10_Projeto.md`
- [ ] `10_Dados.md`
- [ ] `90_GLOSSARIO.md`
- [ ] `91_COMO_ALTERAR.md`
- [ ] `92_EXERCICIOS.md`
- [ ] Referência e histórico em `DOCUMENTACAO_PROJETO.txt`

**CONTINUAR EM:** `10_Program.md`
