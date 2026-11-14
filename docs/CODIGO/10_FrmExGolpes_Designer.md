# `Forms/FrmExGolpes.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** monta os painéis de navegação e o cartão rolável dos exemplos de golpes.
**Depende de:** Windows Forms.  
**É usado por:** `FrmExGolpes.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre Designer, painel de fluxo, Anchor e Labels.

## Explicação por blocos de linhas

- **1–18:** namespace, classe parcial, descarte e início da montagem.
- **19–29:** cria três botões, dois painéis e quatro Labels.
- **30–118:** configura botões com tamanho mínimo, crescimento automático, padding, cores e eventos.
- **119–169:** configura `pnlTopo` e `pnlRodape` com colunas `AutoSize`, `100%` e `AutoSize`.
- **170–188:** configura `flowLayoutPanel1` com `Dock = Fill`, rolagem, direção vertical, controles e padding.
- **190–225:** configura os Labels sem `MaximumSize` fixo; `LarguraTexto` calcula a largura disponível.

### Controles

| Controle | Tipo | Uso |
|---|---|---|
| `BtnAnterior` | `Button` | Golpe anterior |
| `BtnAvancar` | `Button` | Próximo golpe |
| `BtnVoltar` | `Button` | Fechar a tela |
| `flowLayoutPanel1` | `FlowLayoutPanel` | Área de conteúdo rolável |
| `lblNomeGolpe` | `Label` | Nome carregado |
| `lblFuncionamento` | `Label` | Explicação carregada |
| `lblTexto` | `Label` | Título dos alertas |
| `lblSinaisAlerta` | `Label` | Lista de alertas |

## Pontos de atenção

Arquivo gerado pelo Visual Studio. Os painéis evitam posições fixas; os Labels recebem largura dinâmica de `LarguraTexto`, enquanto a lógica de preenchimento fica em `FrmExGolpes.cs`.

## Se der erro aqui

Campos ou eventos renomeados quebram a classe parcial. Textos de designer não substituem o conteúdo carregado em tempo de execução.

## O que posso mudar com segurança?

Aparência e propriedades visuais podem ser ajustadas no Designer. Preserve o painel rolável para conteúdo extenso.

## Mini-resumo

1. Monta painéis de topo e rodapé.
2. Monta botões com crescimento automático.
3. Monta painel de conteúdo preenchendo o espaço restante.
4. Organiza texto de golpe e alertas.
5. Liga fechamento, anterior e avanço.
