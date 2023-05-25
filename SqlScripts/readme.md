Scaffolding

dotnet ef dbcontext scaffold "Name=ConnectionStrings:DefaultConnection" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models/Generated

###########
It's important to use partial class to keep the business logic separate from the scaffolded entities, so that the business logic won't be overwritten.
Example: If an entity named Customer is scaffolded, then we should create another partial class named Customer to separate the business logic and the entity from databases.