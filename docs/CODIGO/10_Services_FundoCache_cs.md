# Services\FundoCache.cs

- Nível: 🟡
- Para que serve: arquivo real conferido no commit a1c33b1.
- Quem depende: componentes que usam este serviço, configuração ou dado.

## Antes de ler
A tabela cobre cada linha do arquivo, em ordem. Arquivos Designer são gerados pelo Visual Studio.

## Leitura linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using System.Drawing.Drawing2D;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 2 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 3 | `namespace ProtetorDigital.Services;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 4 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 5 | `public static class FundoCache` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 6 | `{` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 7 | `    private static readonly object Sincronizacao = new();` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 8 | `    private static Bitmap? _bitmap;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 9 | `    private static Size _tamanho;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 10 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 11 | `    public static void Precarregar(Image? imagem, Size tamanho)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 12 | `    {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 13 | `        if (imagem is null) return;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 14 | `        Obter(imagem, tamanho);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 15 | `    }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 16 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 17 | `    public static Bitmap? Obter(Image? imagem, Size tamanho)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 18 | `    {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 19 | `        if (imagem is null \|\| tamanho.Width <= 0 \|\| tamanho.Height <= 0) return null;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 20 | `        lock (Sincronizacao)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 21 | `        {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 22 | `            if (_bitmap is not null && Math.Abs(_tamanho.Width - tamanho.Width) <= 50 && Math.Abs(_tamanho.Height - tamanho.Height) <= 50)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 23 | `                return _bitmap;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 24 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 25 | `            var novo = new Bitmap(tamanho.Width, tamanho.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 26 | `            using (var graphics = Graphics.FromImage(novo))` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 27 | `            {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 28 | `                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 29 | `                graphics.DrawImage(imagem, new Rectangle(Point.Empty, tamanho));` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 30 | `            }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 31 | `            _bitmap?.Dispose();` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 32 | `            _bitmap = novo;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 33 | `            _tamanho = tamanho;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 34 | `            return _bitmap;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 35 | `        }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 36 | `    }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 37 | `}` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |

## Se der erro aqui, o que acontece?
A compilação, a configuração, a carga dos dados ou a tela dependente pode falhar.

## O que posso mudar com segurança?
Preserve nomes, tipos, caminhos e formatos consumidos pelos dependentes.

## Pontos de atenção
Confira as linhas no arquivo real antes de editar.

## Mini-resumo
1. Arquivo conferido no commit a1c33b1.
2. Cada linha foi listada.
3. Dependentes usam este contrato.
4. Mudanças exigem validação.
5. Recompile e teste.
