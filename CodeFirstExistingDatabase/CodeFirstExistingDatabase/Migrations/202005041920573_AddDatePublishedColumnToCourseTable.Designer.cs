﻿// <auto-generated />
namespace CodeFirstExistingDatabase.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.0")]
    public sealed partial class AddDatePublishedColumnToCourseTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddDatePublishedColumnToCourseTable));
        
        string IMigrationMetadata.Id
        {
            get { return "202005041920573_AddDatePublishedColumnToCourseTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}