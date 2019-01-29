using System;
using System.Collections.Generic;
using System.Text;

namespace TrabPost.Classes
{
    class Poste
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Poste() { }

        public Poste(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentarios(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoverComentarios( Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }
    }
}
