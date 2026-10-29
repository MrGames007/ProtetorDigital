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
| 7–12 | `EstadoFormulario` | Guarda tamanho-base, fontes e escala anterior. | Cada janela tem seu próprio estado. | 🔴 |
| 9 | `TamanhoBase` | Guarda referência de largura e altura. | A escala compara o tamanho atual com essa base. | 🟡 |
| 10 | `Dictionary<Control,float>` | Liga cada controle ao tamanho original da fonte. | Permite recalcular sem acumular erro. | 🔴 |
| 11 | `UltimaEscala = 1f` | Começa com escala 1. | 1 significa 100%. | 🟡 |
| 14 | `Estados` | Guarda o estado de cada Form. | Evita registrar a mesma janela duas vezes. | 🔴 |
| 16–21 | `Registrar(Form, Size)` e teste | Cria o registro, a menos que já exista. | Não duplica eventos. | 🟡 |
| 23–25 | criação e armazenamento | Monta o estado e visita os controles. | Salva fontes iniciais. | 🔴 |
| 26 | evento `Resize` | Chama `Redimensionar` quando a janela muda. | A interface acompanha o tamanho. | 🔴 |
| 27–34 | evento `FormClosed` | Remove controles e estado ao fechar. | Libera referências guardadas. | 🔴 |
| 35 | primeira chamada | Ajusta a janela imediatamente. | Não espera o primeiro resize. | 🟡 |
| 38–45 | `Registrar(Control)` | Registra um controle criado depois. | Útil quando a interface é montada em código. | 🔴 |
| 47–54 | `RegistrarControles` | Visita o controle e todos os filhos. | Contêineres podem conter outros contêineres. | 🔴 |
| 56–68 | `RegistrarControle` | Salva o tamanho da fonte se ainda não salvou. | Evita duplicação e não registra o próprio Form. | 🔴 |
| 70–76 | início de `Redimensionar` | Calcula escala com base na largura e altura. | Usa o menor fator para caber nos dois sentidos. | 🔴 |
| 78–82 | limiar | Ignora mudança menor que 0,02, mas atualiza larguras. | Evita recriar fontes a todo instante. | 🔴 |
| 84 | `SuspendLayout` | Pausa reposicionamentos visuais. | Reduz repintura durante a atualização. | 🟡 |
| 85–101 | `try` e `foreach` | Recria fontes dos controles, respeitando mínimo 12, e descarta a anterior. | Impede acumular fontes GDI. | 🔴 |
| 102–103 | atualiza estado e larguras | Guarda a escala aplicada e quebra Labels. | Mantém próximo resize correto. | 🟡 |
| 105–108 | `finally` | Retoma o layout mesmo se houver falha. | Evita deixar a tela suspensa. | 🔴 |
| 111–122 | `AtualizarLarguras` | Percorre filhos e calcula `MaximumSize` de Labels automáticos. | Textos longos devem quebrar dentro do contêiner. | 🔴 |

## Pontos de atenção

A escala não altera a fonte do próprio Form, mas recria as fontes dos controles. O código compara a referência da fonte anterior com a do Form antes de descartar. O cálculo usa `ClientSize`, não o tamanho externo da janela.

## Se der erro aqui

Um controle descartado é ignorado. Um estado duplicado não é registrado de novo. Se a atualização de fonte falhar, `finally` tenta reativar o layout.

## O que posso mudar com segurança?

É seguro mudar limites da escala ou o tamanho mínimo, desde que a experiência visual seja testada. Não remova a guarda de 0,02 nem o descarte sem entender o risco de muitas fontes GDI.

## Mini-resumo

1. Cada Form recebe um estado.
2. O estado guarda fontes-base.
3. Resize calcula uma escala.
4. Fontes são recriadas com mínimo 12.
5. Labels recebem largura máxima atualizada.
