using System.Text.RegularExpressions;
                    patch.AppendText(input);
                    if (i < lines.Length - 1)
                        patch.AppendText("\n");
                    Match regexMatch = Regex.Match(input, "[-]{3}[ ][\\\"]{0,1}[aiwco12]/(.*)[\\\"]{0,1}");
                    Match regexMatch = Regex.Match(input, "[+]{3}[ ][\\\"]{0,1}[biwco12]/(.*)[\\\"]{0,1}");
                                      "[ ][\\\"]{0,1}[aiwco12]/(.*)[\\\"]{0,1}[ ][\\\"]{0,1}[biwco12]/(.*)[\\\"]{0,1}");
            patch.FileNameA = match.Groups[1].Value.Trim();
            patch.FileNameB = match.Groups[2].Value.Trim();