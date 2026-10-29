# `Forms/FrmBiblioteca.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** apresenta os três tipos de conteúdo e um botão de retorno.  
**Depende de:** Form de origem, telas de dicas, relatos e golpes, `TableLayoutPanel` e `Responsivo`.  
**É usado por:** `FrmMenu`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre campos, construtores, eventos, `Show`, `Hide`, `Close` e layout.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1–7 | `using` | Importam tipos usados pelo arquivo. | Alguns são explícitos; outros podem não ser usados diretamente. | 🟢 |
| 9–12 | namespace e classe parcial | Declaram a janela. | A classe continua a montagem do Designer. | 🟡 |
| 13 | `_janelaOrigem` | Guarda a janela anterior. | Permite voltar ao menu. | 🟡 |
| 14–17 | construtor | Recebe origem e chama o Designer. | Prepara o estado inicial. | 🟡 |
| 18–20 | configurações da janela | Define mínimo, maximização e posição. | Mantém a janela redimensionável. | 🟢 |
| 21 | limpa controles | Remove a montagem inicial. | A nova grade será usada. | 🟡 |
| 22–28 | cria layout | Configura uma coluna e cinco linhas. | Organiza título, três botões e retorno. | 🟡 |
| 29–30 | estilos e `for` | Divide alturas em percentuais. | Faz o conteúdo crescer com a janela. | 🟡 |
| 31–33 | Dock e margem | Faz controles ocuparem células com espaçamento. | Padroniza os botões. | 🟡 |
| 34–38 | adiciona controles | Coloca os controles na ordem visual. | Define o fluxo da Biblioteca. | 🟢 |
| 39–40 | adiciona e registra | Exibe layout e ativa escala. | Mantém textos legíveis. | 🔴 |
| 43–47 | `BtnVoltar_Click` | Mostra origem e fecha a Biblioteca. | Retorna ao menu sem criar outro. | 🟢 |
| 49–54 | `BtnRelatos_Click` | Abre Relatos, mostra e oculta Biblioteca. | Passa esta janela como origem. | 🟡 |
| 56–61 | `BtnDicas_Click` | Faz o mesmo para Dicas. | Mantém padrão de navegação. | 🟡 |
| 63–68 | `BtnExGolpe_Click` | Faz o mesmo para Golpes. | Mantém padrão de navegação. | 🟡 |
| 69–71 | chaves | Fecham classe e arquivo. | Encerram os blocos. | 🟢 |

## Pontos de atenção

A janela origem é um `Form` genérico. O código usa `Show` e `Hide`, portanto a Biblioteca não é modal.

## Se der erro aqui

Se uma tela filha não for encontrada, o botão correspondente não compilará. Se a origem não existir, o retorno falhará.

## O que posso mudar com segurança?

É seguro trocar os textos dos botões no Designer e ajustar linhas do layout. Preserve a origem ao criar uma tela filha para manter o retorno.

## Mini-resumo

1. Biblioteca é um menu intermediário.
2. Recebe sua origem.
3. Usa cinco linhas proporcionais.
4. Cada botão abre uma tela.
5. Voltar mostra a origem e fecha.
