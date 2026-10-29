# `Forms/FrmQuiz.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** monta o Label da pergunta, quatro RadioButtons e os botões do Quiz.  
**Depende de:** Windows Forms.  
**É usado por:** `FrmQuiz.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre Designer, `RadioButton`, `Anchor`, `MaximumSize`, eventos e `Dispose`.

## Explicação por blocos de linhas

- **1–18:** namespace, classe parcial, componente, descarte e início de `InitializeComponent`.
- **19–37:** cria e configura `lblPergunta`, com fonte em negrito, largura máxima e texto atualizado pelo Quiz.
- **39–51:** configura `RBtnAlt1`; os quatro RadioButtons repetem o padrão de fonte, cor, margem e seleção.
- **53–93:** configura `RBtnAlt2`, `RBtnAlt3` e `RBtnAlt4`, diferenciados por nome, posição e `TabIndex`.
- **95–112:** configura `BtnVoltar`, com evento de retorno.
- **114–132:** configura `BtnConfirmar`, ancorado no topo à direita, verde e ligado ao evento de confirmação.
- **134–153:** configura Form, tamanho inicial, adiciona controles e finaliza layout.
- **156–165:** fecha região e declara os sete controles.

### Controles

| Controle | Tipo | Uso | Diferença |
|---|---|---|---|
| `lblPergunta` | `Label` | Pergunta atual | Fonte 16 em negrito, `MaximumSize` |
| `RBtnAlt1`–`RBtnAlt4` | `RadioButton` | Alternativas | Posições e índices diferentes |
| `BtnVoltar` | `Button` | Abandona Quiz | Azul e evento voltar |
| `BtnConfirmar` | `Button` | Confirma resposta | Verde, Anchor direito |

## Pontos de atenção

Este arquivo é gerado pelo Visual Studio e não deve ser editado à mão sem necessidade. O texto das alternativas é substituído em `FrmQuiz.cs`, então os controles começam sem texto útil.

## Se der erro aqui

Um evento ausente causa erro de compilação. Se um RadioButton for removido, a lógica do Quiz ainda poderá tentar acessá-lo.

## O que posso mudar com segurança?

Aparência, fontes e posições podem ser ajustadas pelo Designer. A quantidade de alternativas exige alteração coordenada no modelo, JSON e lógica.

## Mini-resumo

1. Monta a pergunta.
2. Monta quatro opções.
3. Monta voltar e confirmar.
4. Define limites iniciais de texto.
5. Liga os eventos usados pela lógica.
