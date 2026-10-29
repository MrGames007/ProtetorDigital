# `Forms/FrmRelatos.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** declara os botões e Labels usados pela tela de relatos.  
**Depende de:** Windows Forms.  
**É usado por:** `FrmRelatos.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre Designer, Anchor, Labels, eventos e `Dispose`.

## Explicação por blocos de linhas

- **1–18:** namespace, classe parcial, componente, descarte e início de montagem.
- **19–48:** cria e configura botão anterior, ancorado embaixo à esquerda, com evento.
- **50–68:** cria e configura botão avançar, ancorado embaixo à direita.
- **69–85:** configura `lblTitulo` e `lblFonte` com posições iniciais e textos provisórios do Designer.
- **87–103:** configura `lblTexto` e `lblLicoesAprendidas`.
- **105–121:** configura `lblRelato` e `lblVitima`.
- **123–131:** cria botão de retorno e liga `BtnRetorno_Click`.
- **133–153:** configura Form, adiciona controles, retoma e executa layout.
- **156–168:** declara campos privados e fecha arquivo.

### Controles

| Controle | Tipo | Uso |
|---|---|---|
| `BtnVoltar` | `Button` | Relato anterior |
| `BtnAvancar` | `Button` | Próximo relato |
| `BtnRetorno` | `Button` | Voltar à Biblioteca |
| `lblTitulo` | `Label` | Título |
| `lblFonte` | `Label` | Fonte |
| `lblVitima` | `Label` | Vítima |
| `lblRelato` | `Label` | Relato |
| `lblTexto` | `Label` | Título de lições |
| `lblLicoesAprendidas` | `Label` | Lições |

## Pontos de atenção

É arquivo gerado. Os textos `label1` são valores iniciais do Designer; a lógica substitui vários deles ao carregar. O formulário usa posições fixas no Designer, embora o código registre responsividade.

## Se der erro aqui

Campos ou referências de eventos incorretos impedem compilação. Um controle não adicionado não aparecerá.

## O que posso mudar com segurança?

Ajuste visual pelo Designer. Para novos dados, atualize modelo, JSON e lógica, não apenas este arquivo.

## Mini-resumo

1. Declara controles de relatos.
2. Configura navegação.
3. Reserva Labels para dados.
4. Liga eventos.
5. A lógica atualiza os textos.
