# `Forms/FrmExGolpes.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** carrega exemplos de golpes e navega entre eles.  
**Depende de:** `ExGolpe`, `exgolpes.json`, JSON, LINQ e controles do Designer.  
**É usado por:** `FrmBiblioteca`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre JSON, listas, nulos, `try/catch`, `foreach` e eventos.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1–11 | imports | Importam tipos de coleção, arquivo, JSON, LINQ e Forms; há um using duplicado. | Fornecem as ferramentas do arquivo. | 🟢 |
| 13–18 | classe e campos | Declaram lista de golpes e índice. | Guardam dados e posição. | 🟡 |
| 20–31 | construtor | Guarda origem, monta controles, liga eventos e responsividade. | Prepara a janela. | 🟡 |
| 34–60 | `FrmExGolpes_Load` | Localiza arquivo, lê raiz e desserializa itens. | Alimenta a tela. | 🟡 |
| 38–43 | caminhos | Usa saída e fallback de desenvolvimento. | Aceita os dois ambientes. | 🟡 |
| 45–53 | leitura do documento | Confere existência, configura opções e lê `itens`. | O JSON tem raiz objeto. | 🟡 |
| 55 | primeira exibição | Mostra o primeiro golpe quando a lista não está vazia. | Inicia navegação. | 🟢 |
| 57–59 | `catch` vazio | Ignora falhas. | Evita quebrar UI, mas não informa causa. | 🟡 |
| 62–79 | `MostrarGolpe` | Valida índice, pega golpe e preenche Labels. | Atualiza conteúdo visível. | 🟡 |
| 69–78 | sinais | Junta alertas com hífen ou limpa o Label. | Exibe a lista de forma simples. | 🟢 |
| 81–84 | avançar | Mostra próximo golpe se existir. | Impede índice além do fim. | 🟢 |
| 86–90 | voltar | Mostra anterior ou fecha no primeiro. | Define retorno local. | 🟢 |
| 92–96 | retornar | Mostra origem e fecha. | Volta à Biblioteca. | 🟢 |
| 98–100 | linhas vazia e chaves | Não executam e fecham blocos. | Organização. | 🟢 |

## Pontos de atenção

Há um `using` duplicado. O `catch` não informa erros. O nome `BtnRetornar_Click` existe mesmo que o botão possa estar ligado pelo Designer.

## Se der erro aqui

Falha de arquivo ou JSON deixa a lista sem dados. Índices fora da faixa são ignorados.

## O que posso mudar com segurança?

É seguro adicionar registros respeitando `itens` e os nomes esperados pelo modelo. Alterações no `catch` exigem decidir como a aplicação deve informar falhas.

## Mini-resumo

1. A tela trabalha com `ExGolpe`.
2. Carrega objeto raiz com `itens`.
3. Mostra nome e funcionamento.
4. Mostra sinais em linhas.
5. Possui navegação e retorno.
