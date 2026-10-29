# `Forms/FrmCreditos.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** cria a janela modal de Créditos a partir de `creditos.json`, sem colocar os textos de crédito no código.  
**Depende de:** `CreditosInfo`, `ConteudoService`, `Responsivo`, Windows Forms, imagens e reflection.  
**É usado por:** `FrmMenu`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre JSON, propriedades, `TableLayoutPanel`, eventos, `using`, `PictureBox` e fontes.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1–3 | imports | Importam reflection, modelos e serviços. | Permitem versão, dados e responsividade. | 🟡 |
| 5–10 | namespace, classe e campos | Declaram janela selada e guardam layout e botão. | O layout precisa ser acessado durante a montagem. | 🟡 |
| 12–14 | construtor e carregamento | Lê `creditos.json` ou cria dados vazios. | A tela é alimentada externamente. | 🟡 |
| 15–22 | configurações da janela | Define título, mínimo, posição, teclas e fundo. | Prepara o comportamento da janela. | 🟡 |
| 24–35 | criação de `_fechar` | Cria e estiliza o botão. | O botão é montado em código. | 🟢 |
| 36–46 | eventos do botão e teclado | Fecha ao clicar, Enter ou Esc. | Atende o fluxo modal. | 🟡 |
| 48–61 | tabela principal | Cria cinco linhas, com tamanhos automáticos e percentuais. | Distribui título, subtítulo, linhas, cartões e botão. | 🟡 |
| 63–73 | Label de título | Usa o título do JSON e centraliza. | Evita texto de crédito fixo no código. | 🟢 |
| 75–85 | Label de subtítulo | Usa o subtítulo externo. | Mantém conteúdo editável. | 🟢 |
| 87–98 | tabela de linhas | Cria cartão branco com duas colunas. | Separa rótulo e valor. | 🟡 |
| 99–124 | loop das linhas | Cria Labels e substitui `auto` pela versão do assembly. | Cada item JSON vira uma linha visual. | 🔴 |
| 125–127 | painel de linhas | Adiciona margem e coloca a tabela na linha principal. | Mantém espaçamento visual. | 🟢 |
| 129–142 | tabela de cartões | Cria duas colunas e adiciona até dois cartões. | Coloca Desenvolvimento e Apoio lado a lado. | 🟡 |
| 143–148 | botão e registro | Adiciona Fechar e registra controles. | Ativa escala de fontes. | 🔴 |
| 151–161 | `CriarCartao` e painel | Declara fábrica de cartão com três linhas. | Reutiliza a mesma montagem para cada cartão. | 🟡 |
| 162–173 | linhas e título do cartão | Define proporções e título. | Reserva áreas do cartão. | 🟢 |
| 174–177 | corpo e PictureBox | Divide logo e texto e usa Zoom. | A imagem se adapta sem deformar. | 🟡 |
| 178–183 | caminho e imagem opcional | Só carrega logo se o arquivo existir; copia Bitmap. | Ausência da imagem não causa erro e libera o arquivo. | 🔴 |
| 184–195 | controles do corpo | Adiciona logo, texto e painel inferior. | Completa o cartão. | 🟡 |
| 196–198 | retorno e chaves | Devolve o cartão e fecha método/classe. | Entrega o controle ao chamador. | 🟢 |

## Pontos de atenção

Os textos de crédito vêm do JSON, mas o botão de interface `Fechar` é texto de controle. Se o JSON estiver ausente, a tela fica vazia em vez de mostrar erro. O método aceita no máximo dois cartões porque usa `Math.Min(2, ...)`.

## Se der erro aqui

JSON inválido pode lançar erro durante o construtor. Logo ausente é tratada normalmente. Um cartão sem texto continua sendo criado com string vazia.

## O que posso mudar com segurança?

Edite títulos, linhas, textos e nomes de logos no JSON. Para mudar o layout, ajuste percentuais e padding; mantenha os contêineres para preservar responsividade.

## Mini-resumo

1. Créditos é criado em código.
2. Conteúdo vem do JSON.
3. Linhas usam duas colunas.
4. Cartões usam PictureBox opcional.
5. Enter e Esc fecham a janela.
