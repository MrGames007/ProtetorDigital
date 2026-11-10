# 93 — Achados

| Arquivo | Linha | Descrição | Sugestão |
|---|---:|---|---|
| `dados/creditos.json` | 1–20 | O arquivo contém comentários e vírgulas aceitos pelo `ConteudoService`, mas ferramentas JSON estritas o rejeitam. | Manter o parser configurado ou converter para JSON estrito em uma alteração futura. |
| `Forms/FrmQuiz.cs` | 125 | `Controls.Clear()` remove os controles criados pelo Designer antes de reconstruir a interface. | Revisar a divisão entre Designer e código se o layout crescer. |
| `Services/JanelaPadrao.cs` | 13–17 | O estado de janela é estático e compartilhado em memória entre formulários, não persistido entre execuções. | Persistir apenas se esse comportamento for requisito. |
| `Services/Responsivo.cs` | 101–114 | Fontes são substituídas e as anteriores são descartadas durante o redimensionamento. | Monitorar controles adicionados dinamicamente e testar fechamento/redimensionamento. |
| `DOCUMENTACAO_PROJETO.txt` | histórico | O histórico contém entradas de checkpoints e correções de várias etapas. | Preservar entradas antigas e continuar acrescentando linhas cronológicas. |
