# Simple Factory Pattern

## O que é?
Um padrão que centraliza a criação de objetos. Em vez de criar `new Email()` em vários lugares, você pede para uma classe factory (`NotificationFactory`) criar para você.

## Para que serve?
- Evitar espalhir `new` em vários lugares do código
- Facilitar manutenção: se muda como criar, muda só em um lugar
- Desacoplar: quem usa não precisa saber qual classe concreta será criada

## ✅ Prós
- Centraliza criação de objetos
- Fácil adicionar novos tipos
- Código cliente fica simples

## ❌ Contras
- Factory pode ficar grande (muitos if/else)
- String literal é frágil (maiúscula/minúscula)
- Erros só aparecem em runtime

## Estrutura
```
SimpleFactory/
├── Program.cs (menu, entrada)
├── Controller/NotificationController.cs
├── Interface/INotification.cs
├── Service/NotificationFactory.cs (cria objetos)
└── Strategy/ (Email.cs, SMS.cs, WhatsApp.cs)
```

## Como usar
```powershell
dotnet run
```

## Exemplo rápido
```csharp
// Sem factory: acoplado
INotification notif = new Email();

// Com factory: desacoplado
INotification notif = NotificationFactory.Create("Email");
notif.Send(recipient, message);
```
