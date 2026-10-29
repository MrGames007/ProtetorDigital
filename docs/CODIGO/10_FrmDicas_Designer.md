# `Forms/FrmDicas.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** monta botões de navegação e um `FlowLayoutPanel` com os textos da dica.  
**Depende de:** Windows Forms.  
**É usado por:** `FrmDicas.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre Designer, `FlowLayoutPanel`, Anchor, MaximumSize e eventos.

## Explicação por blocos de linhas

- **1–18:** namespace, classe parcial, componente, descarte e início de `InitializeComponent`.
- **19–28:** cria três botões, um fluxo e quatro Labels; suspende os layouts.
- **30–47:** configura `BtnAvancar`, ancorado embaixo à direita, azul e ligado à aparência de botão.
- **49–66:** configura `BtnVoltar`, ancorado embaixo à esquerda, com texto anterior.
- **68–85:** configura `BtnRetornar`, botão superior com evento de retorno.
- **87–102:** configura `flowLayoutPanel1`: rolagem, direção vertical, controles filhos, padding, Anchor e sem quebra horizontal.
- **104–115:** configura `lblTitulo` com fonte grande, cor azul e `MaximumSize`.
- **116–127:** configura `lblDescricao` com fonte regular e largura máxima.
- **128–138:** configura `label3`, texto fixo de seção e destaque verde.
- **139–181:** configura `lblPassos`, define o Form, adiciona controles, retoma layout e declara campos.

### Controles

| Controle | Tipo | Uso |
|---|---|---|
| `BtnAvancar` | `Button` | Próxima dica |
| `BtnVoltar` | `Button` | Dica anterior |
| `BtnRetornar` | `Button` | Voltar à Biblioteca |
| `flowLayoutPanel1` | `FlowLayoutPanel` | Área rolável vertical |
| `lblTitulo` | `Label` | Título carregado |
| `lblDescricao` | `Label` | Descrição carregada |
| `label3` | `Label` | Seção “O que fazer?” |
| `lblPassos` | `Label` | Passos carregados |

## Pontos de atenção

É gerado pelo Visual Studio. A largura máxima dos textos é importante para quebra de linha. A classe de lógica liga alguns eventos novamente no construtor.

## Se der erro aqui

Um evento ou campo com nome diferente quebra a compilação. O painel ainda pode aparecer, mas o conteúdo dependerá da lógica.

## O que posso mudar com segurança?

Ajuste aparência no Designer. Preserve `AutoScroll`, `FlowDirection`, `WrapContents` e `MaximumSize` se textos longos forem esperados.

## Mini-resumo

1. Cria botões de navegação.
2. Cria painel com rolagem.
3. Organiza conteúdo verticalmente.
4. Limita largura de textos.
5. Declara campos para o `.cs` usar.
