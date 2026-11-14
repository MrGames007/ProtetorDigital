# `Forms/FrmDicas.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** monta painéis de topo e rodapé, botões de navegação e um `FlowLayoutPanel` com os textos da dica.
**Depende de:** Windows Forms.  
**É usado por:** `FrmDicas.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre Designer, `FlowLayoutPanel`, Anchor, MaximumSize e eventos.

## Explicação por blocos de linhas

- **1–18:** namespace, classe parcial, componente, descarte e início de `InitializeComponent`.
- **19–29:** cria três botões, dois `TableLayoutPanel`, um fluxo e quatro Labels; suspende os layouts.
- **30–118:** configura os botões com `AutoSize`, tamanho mínimo, padding, fonte, cores e eventos.
- **119–169:** configura `pnlTopo` e `pnlRodape` com colunas `AutoSize`, `100%` e `AutoSize`.
- **170–188:** configura `flowLayoutPanel1` com `Dock = Fill`, rolagem, direção vertical, controles filhos, padding e sem quebra horizontal.
- **190–225:** configura os Labels sem `MaximumSize` fixo; a largura é calculada por `LarguraTexto`.
- **128–138:** configura `label3`, texto fixo de seção e destaque verde.
- **139–181:** configura `lblPassos`, define o Form, adiciona controles, retoma layout e declara campos.

### Controles

| Controle | Tipo | Uso |
|---|---|---|
| `BtnAvancar` | `Button` | Próxima dica |
| `BtnAnterior` | `Button` | Dica anterior |
| `BtnVoltar` | `Button` | Fechar a tela |
| `flowLayoutPanel1` | `FlowLayoutPanel` | Área rolável vertical |
| `lblTitulo` | `Label` | Título carregado |
| `lblDescricao` | `Label` | Descrição carregada |
| `label3` | `Label` | Seção “O que fazer?” |
| `lblPassos` | `Label` | Passos carregados |

## Pontos de atenção

É gerado pelo Visual Studio. O conteúdo ocupa o espaço entre os painéis de topo e rodapé. Os Labels não possuem largura fixa: `LarguraTexto` calcula a largura disponível do painel.

## Se der erro aqui

Um evento ou campo com nome diferente quebra a compilação. O painel ainda pode aparecer, mas o conteúdo dependerá da lógica.

## O que posso mudar com segurança?

Ajuste aparência no Designer. Preserve `AutoScroll`, `FlowDirection`, `WrapContents` e o callback de `LarguraTexto` se textos longos forem esperados.

## Mini-resumo

1. Cria painéis de topo e rodapé.
2. Cria botões com tamanho mínimo e crescimento automático.
3. Cria painel com rolagem e `Dock = Fill`.
4. Organiza conteúdo verticalmente.
5. Declara campos para o `.cs` usar.
