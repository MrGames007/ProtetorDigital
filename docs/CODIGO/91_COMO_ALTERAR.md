# 91 — Como alterar com segurança

## Trocar texto de tela
1. Localize o `Text =` no `.cs` ou `.Designer.cs` indicado pelo formulário.
2. Altere apenas a string.
3. Compile e confira a tela.

## Mudar cores ou fontes
Altere `Color`, `Font` e propriedades do controle no formulário responsável. Em telas responsivas, `Responsivo` reaplica o tamanho da fonte.

## Adicionar conteúdo
- Pergunta: acrescente um item no array de `dados/perguntas.json`, com quatro opções e `respostaCorreta` válido.
- Dica: acrescente item em `dados/dicas.json`, preservando `itens`, `id`, `titulo`, `descricao` e `passos_recomendados`.
- Golpe: preserve `nome_golpe`, `como_funciona` e `sinais_de_alerta` em `dados/exgolpes.json`.
- Relato: preserve os campos de `Relato`; `url` deve ser HTTP/HTTPS para exibir o link.

## Editar créditos
Edite `dados/creditos.json`, mantendo `linhas`, `cartoes` e os nomes esperados por `CreditosInfo`. Os comentários `// TODO` são aceitos pelo serviço.

## Adicionar botão ou tela
Use o Designer para criar o controle e o formulário; ligue o evento no arquivo `.cs`, registre a tela em `JanelaPadrao`/`Responsivo` quando aplicável e compile.

## Tamanho mínimo
Ajuste `MinimumSize` no formulário que define a restrição; no Quiz o valor atual é definido no construtor.

## Publicar
Use o perfil `Properties/PublishProfiles/Windows.pubxml`: ele configura `win-x64`, self-contained, single-file e cópia de `dados`/`imagens`.

## Atenção
Não altere `.Designer.cs` manualmente sem necessidade. Faça backup, valide os JSONs e teste o fluxo visual.
