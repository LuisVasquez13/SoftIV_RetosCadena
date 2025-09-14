using System;
using System.IO;
using System.Linq;
using System.Text;

// VARIABLES INICIALES
string cuentoPath = "cuento.txt";               // Ruta del archivo de entrada
string resultadoPath = "resultado.txt";         // Ruta del archivo de salida
string nombre = "Bitin";                        // Nombre del protagonista
string meta = "descubrir el origen del universo"; // Meta del protagonista
string vacia = "";                              // Cadena vacía
string espacios = "   ";                        // Cadena con solo espacios
var resultados = new StringBuilder();           // Acumulador de resultados

// VALIDACIÓN DE EXISTENCIA DEL ARCHIVO
if (!File.Exists(cuentoPath))
{
    Console.WriteLine("Archivo cuento.txt no encontrado.");
    return;
}

// LECTURA DEL CUENTO
string cuento = File.ReadAllText(cuentoPath);

// CREACIÓN Y CONVERSIÓN
resultados.AppendLine("1. string.Concat(): " + string.Concat(nombre, "Explorador")); // Une dos cadenas
resultados.AppendLine("2. string.Join(): " + string.Join(" | ", cuento.Split('.'))); // Une oraciones con separador personalizado
resultados.AppendLine("3. string.Format(): " + string.Format("El cuento tiene {0} caracteres y {1} palabras", cuento.Length, cuento.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length)); // Inserta valores en plantilla
resultados.AppendLine($"4. string.Interpolation: El protagonista es {nombre} y busca {meta}"); // Inserta variables directamente en cadena
resultados.AppendLine("5. Convert.ToString(): Longitud del cuento: " + Convert.ToString(cuento.Length)); // Convierte número a texto

// BÚSQUEDA Y LOCALIZACIÓN
resultados.AppendLine("6. IndexOf(): " + cuento.IndexOf("mundo")); // Busca la primera posición de una palabra
resultados.AppendLine("7. LastIndexOf(): " + cuento.LastIndexOf("ceros")); // Busca la última posición de una palabra
resultados.AppendLine("8. Contains(): " + (cuento.Contains("Nube") ? "Sí contiene 'Nube'" : "No contiene 'Nube'")); // Verifica si existe una palabra
resultados.AppendLine("9. StartsWith(): " + cuento.StartsWith("En el vasto universo")); // Verifica si empieza con cierta frase
resultados.AppendLine("10. EndsWith(): " + cuento.EndsWith("ceros y unos.")); // Verifica si termina con cierta frase

// MANIPULACIÓN DE CONTENIDO
int indexFrase = cuento.IndexOf("ciudades luminosas");
resultados.AppendLine("11. Substring(): " + (indexFrase >= 0 ? cuento.Substring(indexFrase, "ciudades luminosas".Length) : "No encontrada")); // Extrae una frase específica

resultados.AppendLine("12. Remove(): " + (cuento.Length >= 15 ? cuento.Remove(0, 15) : "Texto demasiado corto para Remove")); // Elimina los primeros caracteres

resultados.AppendLine("13. Replace(): " + cuento.Replace("Bitín", "ProgramaX")); // Reemplaza una palabra por otra

int indexFirewall = cuento.IndexOf("firewall");
resultados.AppendLine("14. Insert(): " + (indexFirewall >= 0 ? cuento.Insert(indexFirewall + "firewall".Length, "(IMPORTANTE)") : cuento)); // Inserta texto después de una palabra

resultados.AppendLine("15. PadLeft(): " + nombre.PadLeft(10, '*')); // Rellena a la izquierda con caracteres
resultados.AppendLine("16. PadRight(): " + "Nube".PadRight(12, '-')); // Rellena a la derecha con caracteres
resultados.AppendLine("17. Trim(): " + "   firewall   ".Trim()); // Elimina espacios al inicio y final
resultados.AppendLine("18. TrimStart(): " + " Mundo binario".TrimStart()); // Elimina espacios al inicio
resultados.AppendLine("19. TrimEnd(): " + "Bitin explorador   ".TrimEnd()); // Elimina espacios al final
resultados.AppendLine("20. Split(): " + string.Join(", ", cuento.Split(' ').Take(10))); // Divide en palabras y muestra las primeras 10

// COMPARACIÓN Y VALIDACIÓN
resultados.AppendLine("21. Equals(): " + ("Nube".Equals("nube") ? "Iguales" : "Diferentes")); // Compara dos cadenas (sensible a mayúsculas)
resultados.AppendLine("22. Compare(): " + (string.Compare("Bitin", "Firewall") < 0 ? "Bitin va primero" : "Firewall va primero")); // Compara alfabéticamente
resultados.AppendLine("23. CompareTo(): Resultado: " + "Nube".CompareTo("Cielo") + " (positivo = Nube > Cielo)"); // Compara y devuelve número
resultados.AppendLine("24. IsNullOrEmpty(): " + string.IsNullOrEmpty(vacia)); // Verifica si está vacía
resultados.AppendLine("25. IsNullOrWhiteSpace(): " + string.IsNullOrWhiteSpace(espacios)); // Verifica si solo tiene espacios

// CONVERSIÓN DE MAYÚSCULAS Y MINÚSCULAS
resultados.AppendLine("26. ToLower(): " + cuento.ToLower()); // Convierte todo a minúsculas
resultados.AppendLine("27. ToUpper(): " + cuento.ToUpper()); // Convierte todo a mayúsculas
resultados.AppendLine("28. ToLowerInvariant(): " + "NUBE".ToLowerInvariant()); // Minúsculas sin depender de cultura
resultados.AppendLine("29. ToUpperInvariant(): " + "bitín".ToUpperInvariant()); // Mayúsculas sin depender de cultura

// GUARDAR RESULTADOS EN ARCHIVO
File.WriteAllText(resultadoPath, resultados.ToString()); // Escribe todos los resultados en resultado.txt
Console.WriteLine("Retos completados. Revisa 'resultado.txt' en /bin/debug/net/..."); // Mensaje final en consola