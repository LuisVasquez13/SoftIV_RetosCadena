using System;
using System.IO;
using System.Linq;
using System.Text;

// RUTA BASE JUNTO AL .CS
string carpetaBase = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Cuento y Resultado");

// CREAR CARPETA SI NO EXISTE
Directory.CreateDirectory(carpetaBase);

// RUTAS DE ARCHIVOS
string cuentoPath = Path.Combine(carpetaBase, "cuento.txt");       // Archivo de entrada
string resultadoPath = Path.Combine(carpetaBase, "resultado.txt"); // Archivo de salida

// VARIABLES INICIALES
string nombre = "Bitin";                        // Nombre del protagonista
string meta = "descubrir el origen del universo"; // Meta del protagonista
string vacia = "";                              // Cadena vacía
string espacios = "   ";                        // Cadena con solo espacios
var resultados = new StringBuilder();           // Acumulador de resultados

// VALIDACIÓN DE EXISTENCIA DEL CUENTO
if (!File.Exists(cuentoPath))
{
    Console.WriteLine("Archivo cuento.txt no encontrado en carpeta 'Cuento y Resultado'.");
return;
}

// LECTURA DEL CUENTO
string cuento = File.ReadAllText(cuentoPath);

// CREACIÓN Y CONVERSIÓN
resultados.AppendLine("1. string.Concat(): " + string.Concat(nombre, "Explorador")); // Une dos cadenas
resultados.AppendLine();
resultados.AppendLine("2. string.Join(): " + string.Join(" | ", cuento.Split('.'))); // Une oraciones con separador personalizado
resultados.AppendLine();
resultados.AppendLine("3. string.Format(): " + string.Format("El cuento tiene {0} caracteres y {1} palabras", cuento.Length, cuento.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length)); // Inserta valores en plantilla
resultados.AppendLine();
resultados.AppendLine($"4. string.Interpolation: El protagonista es {nombre} y busca {meta}"); // Inserta variables directamente en cadena
resultados.AppendLine();
resultados.AppendLine("5. Convert.ToString(): Longitud del cuento: " + Convert.ToString(cuento.Length)); // Convierte número a texto
resultados.AppendLine();

// BÚSQUEDA Y LOCALIZACIÓN
resultados.AppendLine("6. IndexOf(): " + cuento.IndexOf("mundo")); // Busca la primera posición de una palabra
resultados.AppendLine();
resultados.AppendLine("7. LastIndexOf(): " + cuento.LastIndexOf("ceros")); // Busca la última posición de una palabra
resultados.AppendLine();
resultados.AppendLine("8. Contains(): " + (cuento.Contains("Nube") ? "Sí contiene 'Nube'" : "No contiene 'Nube'")); // Verifica si existe una palabra
resultados.AppendLine();
resultados.AppendLine("9. StartsWith(): " + cuento.StartsWith("En el vasto universo")); // Verifica si empieza con cierta frase
resultados.AppendLine();
resultados.AppendLine("10. EndsWith(): " + cuento.EndsWith("ceros y unos.")); // Verifica si termina con cierta frase
resultados.AppendLine();

// MANIPULACIÓN DE CONTENIDO
int indexFrase = cuento.IndexOf("ciudades luminosas");
resultados.AppendLine("11. Substring(): " + (indexFrase >= 0 ? cuento.Substring(indexFrase, "ciudades luminosas".Length) : "No encontrada")); // Extrae una frase específica
resultados.AppendLine();

resultados.AppendLine("12. Remove(): " + (cuento.Length >= 15 ? cuento.Remove(0, 15) : "Texto demasiado corto para Remove")); // Elimina los primeros caracteres
resultados.AppendLine();

resultados.AppendLine("13. Replace(): " + cuento.Replace("Bitín", "ProgramaX")); // Reemplaza una palabra por otra
resultados.AppendLine();

int indexFirewall = cuento.IndexOf("firewall");
resultados.AppendLine("14. Insert(): " + (indexFirewall >= 0 ? cuento.Insert(indexFirewall + "firewall".Length, "(IMPORTANTE)") : cuento)); // Inserta texto después de una palabra
resultados.AppendLine();

resultados.AppendLine("15. PadLeft(): " + nombre.PadLeft(10, '*')); // Rellena a la izquierda con caracteres
resultados.AppendLine();
resultados.AppendLine("16. PadRight(): " + "Nube".PadRight(12, '-')); // Rellena a la derecha con caracteres
resultados.AppendLine();
resultados.AppendLine("17. Trim(): " + "   firewall   ".Trim()); // Elimina espacios al inicio y final
resultados.AppendLine();
resultados.AppendLine("18. TrimStart(): " + " Mundo binario".TrimStart()); // Elimina espacios al inicio
resultados.AppendLine();
resultados.AppendLine("19. TrimEnd(): " + "Bitin explorador   ".TrimEnd()); // Elimina espacios al final
resultados.AppendLine();
resultados.AppendLine("20. Split(): " + string.Join(", ", cuento.Split(' ').Take(10))); // Divide en palabras y muestra las primeras 10
resultados.AppendLine();

// COMPARACIÓN Y VALIDACIÓN
resultados.AppendLine("21. Equals(): " + ("Nube".Equals("nube") ? "Iguales" : "Diferentes")); // Compara dos cadenas (sensible a mayúsculas)
resultados.AppendLine();
resultados.AppendLine("22. Compare(): " + (string.Compare("Bitin", "Firewall") < 0 ? "Bitin va primero" : "Firewall va primero")); // Compara alfabéticamente
resultados.AppendLine();
resultados.AppendLine("23. CompareTo(): Resultado: " + "Nube".CompareTo("Cielo") + " (positivo = Nube > Cielo)"); // Compara y devuelve número
resultados.AppendLine();
resultados.AppendLine("24. IsNullOrEmpty(): " + string.IsNullOrEmpty(vacia)); // Verifica si está vacía
resultados.AppendLine();
resultados.AppendLine("25. IsNullOrWhiteSpace(): " + string.IsNullOrWhiteSpace(espacios)); // Verifica si solo tiene espacios
resultados.AppendLine();

// CONVERSIÓN DE MAYÚSCULAS Y MINÚSCULAS
resultados.AppendLine("26. ToLower(): " + cuento.ToLower()); // Convierte todo a minúsculas
resultados.AppendLine();
resultados.AppendLine("27. ToUpper(): " + cuento.ToUpper()); // Convierte todo a mayúsculas
resultados.AppendLine();
resultados.AppendLine("28. ToLowerInvariant(): " + "NUBE".ToLowerInvariant()); // Minúsculas sin depender de cultura
resultados.AppendLine();
resultados.AppendLine("29. ToUpperInvariant(): " + "bitín".ToUpperInvariant()); // Mayúsculas sin depender de cultura
resultados.AppendLine();

// GUARDAR RESULTADOS EN ARCHIVO
File.WriteAllText(resultadoPath, resultados.ToString());
Console.WriteLine("Retos completados. Revisa la carpeta 'Cuento y Resultado' junto al código.");