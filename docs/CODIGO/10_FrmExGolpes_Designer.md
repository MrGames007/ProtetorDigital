# `Forms/FrmExGolpes.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** monta a área de navegação e o cartão rolável dos exemplos de golpes.  
**Depende de:** Windows Forms.  
**É usado por:** `FrmExGolpes.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre Designer, painel de fluxo, Anchor e Labels.

## Explicação por blocos de linhas

- **1–18:** namespace, classe parcial, descarte e início da montagem.
- **19–27:** cria três botões, painel e quatro Labels.
- **30–47:** configura anterior, ancorado embaixo à esquerda.
- **49–67:** configura avançar, ancorado embaixo à direita, com evento.
- **69–86:** configura retornar no topo e seu evento.
- **88–103:** configura `flowLayoutPanel1` com rolagem, direção vertical, controles, padding e Anchor em todos os lados.
- **105–114:** configura nome do golpe com fonte grande e largura máxima.
- **116–125:** configura funcionamento com quebra de linha.
- **127–134:** configura `lblTexto`, título fixo da seção de alertas.
- **135–179:** configura sinais, Form, controles e campos finais.

### Controles

| Controle | Tipo | Uso |
|---|---|---|
| `BtnVoltar` | `Button` | Golpe anterior |
| `BtnAvancar` | `Button` | Próximo golpe |
| `BtnRetornar` | `Button` | Retorno à Biblioteca |
| `flowLayoutPanel1` | `FlowLayoutPanel` | Área de conteúdo rolável |
| `lblNomeGolpe` | `Label` | Nome carregado |
| `lblFuncionamento` | `Label` | Explicação carregada |
| `lblTexto` | `Label` | Título dos alertas |
| `lblSinaisAlerta` | `Label` | Lista de alertas |

## Pontos de atenção

Arquivo gerado pelo Visual Studio. As larguras máximas dos Labels ajudam textos grandes, enquanto a lógica de preenchimento fica em `FrmExGolpes.cs`.

## Se der erro aqui

Campos ou eventos renomeados quebram a classe parcial. Textos de designer não substituem o conteúdo carregado em tempo de execução.

## O que posso mudar com segurança?

Aparência e propriedades visuais podem ser ajustadas no Designer. Preserve o painel rolável para conteúdo extenso.

## Mini-resumo

1. Monta botões.
2. Monta painel de conteúdo.
3. Organiza texto de golpe.
4. Reserva espaço para alertas.
5. Liga retorno e avanço.
