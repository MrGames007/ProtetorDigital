# `Services/Responsivo.cs`

**Nível predominante:** 🔴 avançado  
**Para que serve:** registra formulários e controles e recalcula fontes quando a janela muda de tamanho.  
**Depende de:** Windows Forms, `Dictionary`, `Size`, fontes e eventos.  
**É usado por:** construtores de `FrmMenu`, `FrmBiblioteca`, `FrmQuiz`, `FrmDicas`, `FrmExGolpes`, `FrmRelatos` e `FrmCreditos`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre classes estáticas, dicionário, eventos, lambda, `foreach`, `try/finally`, fontes e `Dispose`.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using System.Drawing;` | Importa `Size` e tipos de desenho. | Tamanho e fontes fazem parte da responsividade. | 🟡 |
| 3 | namespace | Agrupa o serviço. | Separa utilidade compartilhada. | 🟢 |
| 5 | classe estática | Cria a ferramenta global. | Não precisa ser instanciada. | 🟡 |
| 7–14 | `EstadoFormulario` | Guarda tamanho-base, fontes, limites opcionais, escala anterior, timer e callback. | Cada janela tem seu próprio estado. | 🔴 |
| 9 | `TamanhoBase` | Guarda referência de largura e altura. | A escala compara o tamanho atual com essa base. | 🟡 |
| 10 | `Dictionary<Control,float>` | Liga cada controle ao tamanho original da fonte. | Permite recalcular sem acumular erro. | 🔴 |
| 11 | limites por controle | Guarda mínimo e máximo específico, quando cadastrado. | Evita que botões de navegação cresçam até quebrar o texto. | 🔴 |
| 12 | `UltimaEscala = 1f` | Começa com escala 1. | 1 significa 100%. | 🟡 |
| 14 | `Estados` | Guarda o estado de cada Form. | Evita registrar a mesma janela duas vezes. | 🔴 |
| 16–21 | `Registrar(Form, Size, aposAplicar)` e teste | Cria o registro, a menos que já exista, e guarda callback pós-aplicação. | Permite recalcular larguras após redimensionar fontes. | 🟡 |
| 23–25 | criação e armazenamento | Monta o estado e visita os controles. | Salva fontes iniciais. | 🔴 |
| 26 | evento `Resize` | Chama `Redimensionar` quando a janela muda. | A interface acompanha o tamanho. | 🔴 |
| 27–34 | evento `FormClosed` | Remove controles e estado ao fechar. | Libera referências guardadas. | 🔴 |
| 35 | primeira chamada | Ajusta a janela imediatamente. | Não espera o primeiro resize. | 🟡 |
| 38–45 | `Registrar(Control)` e `LimitarFonte` | Registra controle criado depois ou cadastra mínimo/máximo de fonte. | Permite configuração específica sem alterar outros formulários. | 🔴 |
| 47–54 | `RegistrarControles` | Visita o controle e todos os filhos. | Contêineres podem conter outros contêineres. | 🔴 |
| 56–68 | `RegistrarControle` | Salva o tamanho da fonte se ainda não salvou. | Evita duplicação e não registra o próprio Form. | 🔴 |
| 70–76 | início de `Redimensionar` | Calcula escala com base na largura e altura. | Usa o menor fator para caber nos dois sentidos. | 🔴 |
| 78–82 | limiar | Ignora mudança menor que 0,02, mas atualiza larguras. | Evita recriar fontes a todo instante. | 🔴 |
| 84 | `SuspendLayout` | Pausa reposicionamentos visuais. | Reduz repintura durante a atualização. | 🟡 |
| 85–101 | `try` e `foreach` | Recria fontes dos controles, respeitando limites específicos ou o padrão 12–36, e descarta a anterior. | Impede acumular fontes GDI e evita texto cortado. | 🔴 |
| 102–103 | atualiza estado e larguras | Guarda a escala aplicada e quebra Labels. | Mantém próximo resize correto. | 🟡 |
| 105–108 | `finally` | Retoma o layout mesmo se houver falha. | Evita deixar a tela suspensa. | 🔴 |
| 111–122 | callback `AposAplicar` | Executa a ação cadastrada após recalcular fontes. | As telas atualizam suas larguras depois da escala. | 🔴 |

## Pontos de atenção

A escala não altera a fonte do próprio Form, mas recria as fontes dos controles. Sem limite específico, o comportamento padrão continua entre 12 e 36 pt; `LimitarFonte` permite uma faixa própria. O cálculo usa `ClientSize`, não o tamanho externo da janela.

## Se der erro aqui

Um controle descartado é ignorado. Um estado duplicado não é registrado de novo. Se a atualização de fonte falhar, `finally` tenta reativar o layout.

## O que posso mudar com segurança?

É seguro mudar limites da escala ou o tamanho mínimo, desde que a experiência visual seja testada. Não remova a guarda de 0,02 nem o descarte sem entender o risco de muitas fontes GDI.

## Mini-resumo

1. Cada Form recebe um estado.
2. O estado guarda fontes-base.
3. Resize calcula uma escala.
4. Fontes são recriadas com mínimo 12.
5. Callbacks podem recalcular o layout após a escala.
