//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class examen
    {
        public int idExamen { get; set; }
        public Nullable<double> CC1 { get; set; }
        public Nullable<double> CC2 { get; set; }
        public Nullable<double> CC3 { get; set; }
        public Nullable<double> Moyenne { get; set; }
        public string observation { get; set; }
        public Nullable<int> idMatiere { get; set; }
        public Nullable<double> Moy_National { get; set; }
        public Nullable<double> Moy_Regional { get; set; }
        public Nullable<double> CC4 { get; set; }
        public int idinscrit { get; set; }
    
        public virtual inscrit inscrit { get; set; }
        public virtual matiere matiere { get; set; }
    }
}
