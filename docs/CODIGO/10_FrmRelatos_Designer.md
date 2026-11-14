# `Forms/FrmRelatos.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** declara os painéis, botões e Labels usados pela tela de relatos.
**Depende de:** Windows Forms.  
**É usado por:** `FrmRelatos.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre Designer, Anchor, Labels, eventos e `Dispose`.

## Explicação por blocos de linhas

- **1–18:** namespace, classe parcial, componente, descarte e início de montagem.
- **19–29:** cria três botões, dois painéis e os Labels do relato.
- **30–118:** configura os botões com tamanho mínimo, crescimento automático, padding, fonte, cores e eventos.
- **119–169:** configura `pnlTopo` e `pnlRodape` com colunas `AutoSize`, `100%` e `AutoSize`.
- **170–188:** configura `flowLayoutPanel1` com `Dock = Fill`, rolagem, direção vertical, controles e padding.
- **190–230:** configura Labels e LinkLabel sem `MaximumSize` fixo; a largura é calculada em tempo de execução.

### Controles

| Controle | Tipo | Uso |
|---|---|---|
| `BtnAnterior` | `Button` | Relato anterior |
| `BtnAvancar` | `Button` | Próximo relato |
| `BtnVoltar` | `Button` | Fechar a tela |
| `lblTitulo` | `Label` | Título |
| `lblFonte` | `Label` | Fonte |
| `lblVitima` | `Label` | Vítima |
| `lblRelato` | `Label` | Relato |
| `lblTexto` | `Label` | Título de lições |
| `lblLicoesAprendidas` | `Label` | Lições |

## Pontos de atenção

É arquivo gerado. Os textos iniciais são substituídos ao carregar. Os botões e o conteúdo não usam posições fixas; o painel central ocupa o espaço restante e `LarguraTexto` dimensiona os textos.

## Se der erro aqui

Campos ou referências de eventos incorretos impedem compilação. Um controle não adicionado não aparecerá.

## O que posso mudar com segurança?

Ajuste visual pelo Designer. Para novos dados, atualize modelo, JSON e lógica, não apenas este arquivo.

## Mini-resumo

1. Declara painéis e controles de relatos.
2. Configura navegação com botões que crescem com a fonte.
3. Reserva Labels e LinkLabel para dados.
4. Liga eventos de fechamento e navegação.
5. A lógica atualiza textos e larguras.
