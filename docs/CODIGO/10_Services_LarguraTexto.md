# `Services/LarguraTexto.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** calcula a largura disponível para Labels e LinkLabels dentro de um `FlowLayoutPanel`.  
**É usado por:** `FrmDicas`, `FrmExGolpes` e `FrmRelatos`.

## Responsabilidade

`LarguraTexto.Ajustar` recebe o painel de conteúdo e os controles de texto que devem acompanhar seu tamanho. Para cada controle visível, calcula a largura do painel descontando o padding, a barra de rolagem vertical e as margens do próprio controle. A largura mínima aplicada é 200 pixels.

```csharp
LarguraTexto.Ajustar(flowLayoutPanel1, lblTitulo, lblDescricao, label3, lblPassos);
```

## Comportamento

- Ignora referências nulas e controles invisíveis.
- Define `MaximumSize = new Size(largura, 0)` para permitir quebra vertical.
- Mantém `AutoSize = true`.
- Não altera `Location`, `Size` ou `Dock` dos controles.
- É chamado no carregamento, na troca de item, no `SizeChanged` do painel e após o callback do `Responsivo`.

## Pontos de atenção

A classe não conhece o conteúdo dos textos nem a tela que os exibe. Ela apenas aplica a regra comum de largura. Se um novo formulário usar textos longos em um painel rolável, passe todos os Labels e LinkLabels relevantes para `Ajustar`.

## Mini-resumo

1. Recebe um `FlowLayoutPanel` e controles de texto.
2. Calcula a largura útil do painel.
3. Desconta padding, rolagem e margem.
4. Garante largura mínima de 200 pixels.
5. Mantém os controles com `AutoSize` e quebra de linha.
