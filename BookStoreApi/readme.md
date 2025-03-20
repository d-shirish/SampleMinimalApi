# How to Perform a Migration

- Migrations allow you to update the database schema based on changes made to your model classes. In Entity Framework Core, you can use the below command to create a new migration reflecting these changes.

```dotnet ef migrations add InitialCreate```

- After creating the migration, you need to apply the migration to update the database schema. You can use the dotnet ef database update command to apply the migration and update the database.

```dotnet ef database update```
