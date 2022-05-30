using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;  

namespace EBoutique.Models
{
    public class bdBoutiqueContext : DbContext
    {
public bdBoutiqueContext(): base("conn")
        {

        }

        public DbSet<Produit> produits { get; set; }

    }
}