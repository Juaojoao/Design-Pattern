# Strategy Pattern

## O que é?
Um padrão que encapsula diferentes algoritmos em classes separadas. Em vez de usar `if/else` gigantes, cada forma de fazer algo fica em sua própria classe.

## Para que serve?
- Evitar muitos `if/else` no código
- Facilitar adicionar novas formas de fazer algo
- Permitir trocar o algoritmo em tempo de execução
- Cada classe fica responsável por uma coisa

## ✅ Prós
- Elimina muitos if/else
- Fácil testar cada estratégia separadamente
- Fácil adicionar novas estratégias
- Código mais organizado

## ❌ Contras
- Mais classes (uma para cada variação)
- Pode ser excessivo se tem poucas variações
- Overhead de memória

## Estrutura
```
Strategy/
├── Program.cs (menu, entrada)
├── Contract/ITaxStrategy.cs (interface)
├── Controller/TaxController.cs
├── Service/TaxService.cs (seleciona estratégia)
└── Strategy/ (ICMS.cs, IPI.cs, ISS.cs)
```

## Como usar
```powershell
dotnet run
```

## Exemplo rápido
```csharp
// Sem Strategy: código feio
if (taxType == "ICMS")
    tax = baseValue * 0.18m;
else if (taxType == "IPI")
    tax = baseValue * 0.15m;

// Com Strategy: código limpo
ITaxStrategy strategy = TaxService.GetStrategy(taxType);
decimal tax = strategy.Calculate(baseValue);
```

