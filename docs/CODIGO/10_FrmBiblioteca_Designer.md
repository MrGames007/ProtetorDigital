# `Forms/FrmBiblioteca.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** monta inicialmente o título, quatro botões, imagem de fundo e recursos da Biblioteca.  
**Depende de:** Windows Forms e `ComponentResourceManager`.  
**É usado por:** `FrmBiblioteca.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre Designer, `Dispose`, controles e eventos.

## Explicação por blocos de linhas

- **1–30:** namespace, classe parcial, componente, comentários e início de `InitializeComponent`.
- **31–37:** cria recurso visual, `label1`, `BtnVoltar`, `BtnDicas`, `BtnRelatos` e `BtnExGolpe`.
- **39–50:** define o título `Biblioteca`, fonte grande, cor, posição, tamanho e alinhamento.
- **51–68:** configura `BtnVoltar`, sua aparência azul, texto e evento.
- **70–82:** configura `BtnDicas`, cor verde, tamanho inicial, texto e evento.
- **84–96:** configura `BtnRelatos`, cor azul, texto e evento.
- **98–110:** configura `BtnExGolpe`, cor vermelha, texto e evento.
- **112–128:** define Form, imagem de fundo, tamanho inicial, controles e finaliza layout.
- **130–137:** fecha região e declara os controles.

### Controles

| Controle | Tipo | Para que serve | Diferencial |
|---|---|---|---|
| `label1` | `Label` | Título | Fonte 36, texto Biblioteca |
| `BtnVoltar` | `Button` | Retorno | Azul, fonte Lucida Sans Unicode |
| `BtnDicas` | `Button` | Abre dicas | Verde |
| `BtnRelatos` | `Button` | Abre relatos | Azul e texto de casos |
| `BtnExGolpe` | `Button` | Abre golpes | Vermelho |

## Pontos de atenção

É arquivo gerado pelo Visual Studio. O construtor de `FrmBiblioteca` limpa a coleção e remonta os controles em grade, então as coordenadas iniciais não são o layout final.

## Se der erro aqui

Problemas nos nomes dos eventos ou campos quebram a classe parcial. Recursos ausentes podem afetar a imagem de fundo.

## O que posso mudar com segurança?

A aparência pode ser ajustada pelo Designer. O fluxo deve continuar no arquivo `.cs`.

## Mini-resumo

1. Declara a Biblioteca visual.
2. Cria título e botões.
3. Configura cores e textos.
4. Liga eventos.
5. O runtime reorganiza a grade.
