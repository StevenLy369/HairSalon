using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int StylistId {get;set;}
    public string Name { get; set; }
    public virtual Stylist Stylist { get; set; }
    
    // public int StylistId { get; set; }
    // public virtual ICollection<Stylist> Stylists { get; set; }
    
    // public Client()
    // {
    //   this.Stylists = new HashSet<Stylist>();
    // }
  }
}