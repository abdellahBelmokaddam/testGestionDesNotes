﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testGestionDesNotes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class gestion_exmen : DbContext
    {
        public gestion_exmen()
            : base("name=gestion_exmen")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<etudiant> etudiant { get; set; }
        public virtual DbSet<examen> examen { get; set; }
        public virtual DbSet<filiere> filiere { get; set; }
        public virtual DbSet<groupe> groupe { get; set; }
        public virtual DbSet<inscrit> inscrit { get; set; }
        public virtual DbSet<matiere> matiere { get; set; }
        public virtual DbSet<niveau> niveau { get; set; }
    
        public virtual ObjectResult<af_Result> af(Nullable<int> idM, Nullable<int> idG)
        {
            var idMParameter = idM.HasValue ?
                new ObjectParameter("idM", idM) :
                new ObjectParameter("idM", typeof(int));
    
            var idGParameter = idG.HasValue ?
                new ObjectParameter("idG", idG) :
                new ObjectParameter("idG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<af_Result>("af", idMParameter, idGParameter);
        }
    
        public virtual int Affiche(Nullable<int> idMat)
        {
            var idMatParameter = idMat.HasValue ?
                new ObjectParameter("idMat", idMat) :
                new ObjectParameter("idMat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Affiche", idMatParameter);
        }
    
        public virtual ObjectResult<afficheEx_Result> afficheEx(Nullable<int> idM, Nullable<int> idG)
        {
            var idMParameter = idM.HasValue ?
                new ObjectParameter("idM", idM) :
                new ObjectParameter("idM", typeof(int));
    
            var idGParameter = idG.HasValue ?
                new ObjectParameter("idG", idG) :
                new ObjectParameter("idG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<afficheEx_Result>("afficheEx", idMParameter, idGParameter);
        }
    
        public virtual ObjectResult<afficheEx2_Result> afficheEx2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<afficheEx2_Result>("afficheEx2");
        }
    
        public virtual int thebest(Nullable<int> idF)
        {
            var idFParameter = idF.HasValue ?
                new ObjectParameter("idF", idF) :
                new ObjectParameter("idF", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("thebest", idFParameter);
        }
    }
}
