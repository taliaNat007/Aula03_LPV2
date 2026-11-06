Projeto AulaApp1 — Atividade EAD Aula 3

Requisitos: .NET 10 SDK.

Como executar:
1. Abra AulaApp1.csproj no Visual Studio ou abra a pasta do projeto.
2. No terminal, execute: dotnet restore
3. Execute: dotnet run
4. Acesse as rotas /produtos e /categorias.

Validação:
- Produtos: nome obrigatório e preço maior que zero.
- Categorias: nome obrigatório com 3 a 50 caracteres e quantidade entre 0 e 100.000.
- Regra adicional de Categorias: limite de 50 caracteres no nome para manter descrições concisas.

As regras ficam nos modelos por meio de DataAnnotations. As páginas utilizam EditForm,
DataAnnotationsValidator, ValidationMessage e OnValidSubmit. Os formulários só incluem
registros válidos nas tabelas e são reinicializados após cada cadastro bem-sucedido.
