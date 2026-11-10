# Services\JanelaPadrao.cs

- Nível: 🟡
- Para que serve: arquivo real conferido no commit a1c33b1.
- Quem depende: componentes que usam este serviço, configuração ou dado.

## Antes de ler
A tabela cobre cada linha do arquivo, em ordem. Arquivos Designer são gerados pelo Visual Studio.

## Leitura linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using System;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 2 | `using System.Linq;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 3 | `using System.Runtime.CompilerServices;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 4 | `using System.Drawing;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 5 | `using System.Windows.Forms;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 6 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 7 | `namespace ProtetorDigital.Services;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 8 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 9 | `public static class JanelaPadrao` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 10 | `{` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 11 | `    public static readonly Size TamanhoPadrao = new(1201, 700);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 12 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 13 | `    private static Rectangle? _bounds;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 14 | `    private static FormWindowState _windowState = FormWindowState.Normal;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 15 | `    private static bool _temEstado;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 16 | `    private static readonly ConditionalWeakTable<Form, object> FormulariosRegistrados = new();` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 17 | `    private static bool _aplicando;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 18 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 19 | `    public static void Registrar(Form f)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 20 | `    {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 21 | `        if (FormulariosRegistrados.TryGetValue(f, out _)) return;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 22 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 23 | `        FormulariosRegistrados.Add(f, new object());` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 24 | `        f.StartPosition = FormStartPosition.Manual;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 25 | `        Aplicar(f);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 26 | `        f.ResizeEnd += (_, _) => Salvar(f);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 27 | `        f.FormClosing += (_, _) => Salvar(f);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 28 | `        f.SizeChanged += (_, _) =>` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 29 | `        {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 30 | `            if (f.WindowState is FormWindowState.Normal or FormWindowState.Maximized)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 31 | `                Salvar(f);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 32 | `        };` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 33 | `    }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 34 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 35 | `    public static void Aplicar(Form f)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 36 | `    {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 37 | `        if (_aplicando) return;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 38 | `        _aplicando = true;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 39 | `        try` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 40 | `        {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 41 | `            var tela = Screen.FromControl(f);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 42 | `            var area = tela.WorkingArea;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 43 | `            var minimo = f.MinimumSize;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 44 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 45 | `            if (!_temEstado)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 46 | `            {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 47 | `                if (!CabeNaArea(TamanhoPadrao, area, minimo))` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 48 | `                {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 49 | `                    f.WindowState = FormWindowState.Maximized;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 50 | `                    _windowState = FormWindowState.Maximized;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 51 | `                    return;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 52 | `                }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 53 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 54 | `                f.WindowState = FormWindowState.Normal;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 55 | `                f.ClientSize = TamanhoPadrao;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 56 | `                f.Location = Centralizar(f.ClientSize, area).Location;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 57 | `                return;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 58 | `            }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 59 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 60 | `            var bounds = _bounds!.Value;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 61 | `            if (!CruzaAlgumaTela(bounds) \|\| !CabeNaArea(bounds.Size, area, minimo))` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 62 | `            {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 63 | `                if (!CabeNaArea(TamanhoPadrao, area, minimo))` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 64 | `                {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 65 | `                    f.WindowState = FormWindowState.Maximized;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 66 | `                    _windowState = FormWindowState.Maximized;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 67 | `                    return;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 68 | `                }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 69 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 70 | `                f.WindowState = FormWindowState.Normal;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 71 | `                f.ClientSize = TamanhoPadrao;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 72 | `                f.Location = Centralizar(f.ClientSize, area).Location;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 73 | `                _bounds = f.Bounds;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 74 | `                _windowState = FormWindowState.Normal;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 75 | `                return;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 76 | `            }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 77 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 78 | `            f.WindowState = FormWindowState.Normal;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 79 | `            f.Bounds = bounds;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 80 | `            f.WindowState = _windowState;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 81 | `        }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 82 | `        finally` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 83 | `        {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 84 | `            _aplicando = false;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 85 | `        }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 86 | `    }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 87 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 88 | `    private static void Salvar(Form f)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 89 | `    {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 90 | `        if (_aplicando \|\| f.WindowState == FormWindowState.Minimized) return;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 91 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 92 | `        if (f.WindowState == FormWindowState.Maximized)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 93 | `        {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 94 | `            _bounds = f.RestoreBounds;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 95 | `            _windowState = FormWindowState.Maximized;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 96 | `        }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 97 | `        else` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 98 | `        {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 99 | `            _bounds = f.Bounds;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 100 | `            _windowState = FormWindowState.Normal;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 101 | `        }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 102 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 103 | `        _temEstado = true;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 104 | `    }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 105 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 106 | `    private static bool CruzaAlgumaTela(Rectangle bounds)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 107 | `    {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 108 | `        return Screen.AllScreens.Any(tela => tela.WorkingArea.IntersectsWith(bounds));` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 109 | `    }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 110 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 111 | `    private static bool CabeNaArea(Size tamanho, Rectangle area, Size minimo)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 112 | `    {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 113 | `        return tamanho.Width >= minimo.Width && tamanho.Height >= minimo.Height &&` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 114 | `               tamanho.Width <= area.Width && tamanho.Height <= area.Height;` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 115 | `    }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 116 | `` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 117 | `    private static Rectangle Centralizar(Size tamanho, Rectangle area)` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 118 | `    {` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 119 | `        var x = area.Left + Math.Max(0, (area.Width - tamanho.Width) / 2);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 120 | `        var y = area.Top + Math.Max(0, (area.Height - tamanho.Height) / 2);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 121 | `        return new Rectangle(new Point(x, y), tamanho);` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 122 | `    }` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |
| 123 | `}` | Linha do arquivo | Mantém a responsabilidade documentada | 🟢 |

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
