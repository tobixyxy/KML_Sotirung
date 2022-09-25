

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_TEST
{
    internal class PLZ
    {
        public string plz_bundelsland(int plz)
        {
            string bund =  string.Empty;
            switch (plz)
            {
                #region Sachsen
                case > 01001 and <= 01936: { bund =  "Sachsen";} break;
                case > 02601 and <= 02999: { bund =  "Sachsen"; } break;
                case > 04001 and <= 04579: { bund =  "Sachsen"; } break;
                case > 04641 and <= 04889: { bund =  "Sachsen"; } break;
                case 07919: { bund =  "Sachsen"; } break;
                case 07951: { bund =  "Sachsen"; } break;
                case 07952: { bund =  "Sachsen"; } break;
                case 07982: { bund =  "Sachsen"; } break;
                case 07985: { bund =  "Sachsen"; } break;
                case > 08001 and <= 09669: { bund =  "Sachsen"; } break;
                #endregion
                #region Brandenburg
                case > 01941 and <= 01998: { bund =  "Brandenburg"; } break;
                case > 03001 and <= 03253: { bund =  "Brandenburg"; } break;
                case > 04891 and <= 04938: { bund =  "Brandenburg"; } break;
                #endregion
                #region Thüringen
                case > 04581 and <= 04639: { bund =  "Thüringen"; } break;
                case > 06551 and <= 06578: { bund =  "Thüringen"; } break;
                case > 07301 and <= 07919: { bund =  "Thüringen"; } break;
                case > 07920 and <= 07950: { bund =  "Thüringen"; } break;
                case > 07953 and <= 07980: { bund =  "Thüringen"; } break;
                case > 07985 and <= 07989: { bund =  "Thüringen"; } break;
                case > 36401 and <= 36469: { bund =  "Thüringen"; } break;
                case > 37301 and <= 37359: { bund =  "Thüringen"; } break;
                case > 96501 and <= 96529: { bund =  "Thüringen"; } break;
                case > 98501 and <= 99998: { bund =  "Thüringen"; } break;
                #endregion
                #region Sachsen-Anhalt
                case > 06001 and <= 06548: { bund =  "Sachsen-Anhalt"; } break;
                case > 06601 and <= 06928: { bund =  "Sachsen-Anhalt"; } break;
                case 14715: { bund =  "Sachsen-Anhalt"; } break;
                case > 29401 and <= 29416: { bund =  "Sachsen-Anhalt"; } break;
                case > 38481 and <= 38489: { bund =  "Sachsen-Anhalt"; } break;
                case > 38801 and <= 39649: { bund =  "Sachsen-Anhalt"; } break;
                #endregion
                #region Berlin
                case > 10001 and <= 14330: { bund =  "Berlin"; } break;
                #endregion
                #region Brandenburg
                case > 14401 and <= 14715: { bund =  "Brandenburg"; } break;
                case > 14723 and <= 16949: { bund =  "Brandenburg"; } break;
                case 17258: { bund =  "Brandenburg"; } break;
                case > 17261 and <= 17291: { bund =  "Brandenburg"; } break;
                case 17309: { bund =  "Brandenburg"; } break;
                case 17321: { bund =  "Brandenburg"; } break;
                case 17326: { bund =  "Brandenburg"; } break;
                case 17337: { bund =  "Brandenburg"; } break;
                case > 19307 and <= 19357: { bund =  "Brandenburg"; } break;
                #endregion
                #region Mecklenburg-Vorpommern
                case > 17001 and <= 17256: bund =  "Mecklenburg-Vorpommern"; break;
                case > 17258 and 17259: bund =  "Mecklenburg-Vorpommern"; break;
                case > 17301 and <= 17309: bund =  "Mecklenburg-Vorpommern"; break;
                case > 17309 and <= 17321: bund =  "Mecklenburg-Vorpommern"; break;
                case > 17321 and 17322: bund =  "Mecklenburg-Vorpommern"; break;
                case >= 17328 and <= 17331: bund =  "Mecklenburg-Vorpommern"; break;
                case 17335: bund = "Mecklenburg-Vorpommern"; break;
                case > 17337 and <= 19260: bund = "Mecklenburg-Vorpommern"; break;
                case 19273: bund = "Mecklenburg-Vorpommern"; break;
                case > 19273 and <= 19306: bund = "Mecklenburg-Vorpommern"; break;
                case > 19357 and <= 19417: bund = "Mecklenburg-Vorpommern"; break;
                case > 23921 and <= 23999: bund = "Mecklenburg-Vorpommern"; break;
                #endregion
                #region Niedersachsen
                case > 19271 and <= 19273: bund = "Niedersachsen"; break;
                case > 21202 and <= 21449: bund = "Niedersachsen"; break;
                case 21522: bund = "Niedersachsen"; break;
                case > 21601 and <= 21789: bund = "Niedersachsen"; break;
                case > 26001 and <= 27478: bund = "Niedersachsen"; break;
                case >= 27607 and <= 27809: bund = "Niedersachsen"; break;
                case > 28784 and <= 29399: bund = "Niedersachsen"; break;
                case > 29431 and <= 31868: bund = "Niedersachsen"; break;
                case > 34331 and <= 34353: bund = "Niedersachsen"; break;
                case 34355: bund = "Niedersachsen"; break;
                case > 37001 and <= 37194: bund = "Niedersachsen"; break;
                case >= 37197 and <= 37199: bund = "Niedersachsen"; break;
                case > 37401 and <= 37649: bund = "Niedersachsen"; break;
                case > 37689 and <= 37691: bund = "Niedersachsen"; break;
                case >= 37697 and <= 38479: bund = "Niedersachsen"; break;
                case > 38501 and <= 38729: bund = "Niedersachsen"; break;
                case > 48442 and <= 48465: bund = "Niedersachsen"; break;
                case > 48478 and <= 48480: bund = "Niedersachsen"; break;
                case > 48486 and <= 48488: bund = "Niedersachsen"; break;
                case > 48497 and <= 48531: bund = "Niedersachsen"; break;
                case > 49001 and <= 49459: bund = "Niedersachsen"; break;
                case > 49551 and <= 49849: bund = "Niedersachsen"; break;
                #endregion
                #region Hamburg
                case > 20001 and <= 21037: bund = "Hamburg"; break;
                case > 21039 and <= 21170: bund = "Hamburg"; break;
                case > 22001 and < 22113: bund = "Hamburg"; break;
                case >= 22115 and <= 22143: bund = "Hamburg"; break;
                case 22145: bund = "Hamburg"; break;
                case >= 22147 and <= 22786: bund = "Hamburg"; break;
                case 27499: bund = "Hamburg"; break;
                #endregion
                #region Schleswig-Holstein
                case 21039: bund = "Schleswig-Holstein"; break;
                case > 21451 and <= 21521: bund = "Schleswig-Holstein"; break;
                case > 21524 and <= 21529: bund = "Schleswig-Holstein"; break;
                case 22113: bund = "Schleswig-Holstein"; break;
                case > 22801 and <= 23919: bund = "Schleswig-Holstein"; break;
                case > 24001 and <= 25999: bund = "Schleswig-Holstein"; break;
                case > 27483 and <= 27498: bund = "Schleswig-Holstein"; break;
                #endregion
                #region Bremen
                case > 27501 and <= 27580: bund = "Bremen"; break;
                case > 28001 and <= 28779: bund = "Bremen"; break;
                #endregion
                #region Nordrhein-Westfalen
                case > 32001 and <= 33829: bund =  "Nordrhein-Westfalen"; break;
                case > 34401 and <= 34439: bund = "Nordrhein-Westfalen"; break;
                case > 37651 and <= 37688: bund = "Nordrhein-Westfalen"; break;
                case > 37692 and <= 37696: bund = "Nordrhein-Westfalen"; break;
                case > 40001 and <= 48432: bund = "Nordrhein-Westfalen"; break;
                case > 48466 and <= 48477: bund = "Nordrhein-Westfalen"; break;
                case > 48481 and <= 48485: bund = "Nordrhein-Westfalen"; break;
                case > 48489 and <= 48496: bund = "Nordrhein-Westfalen"; break;
                case > 48541 and <= 48739: bund = "Nordrhein-Westfalen"; break;
                case > 49461 and <= 49549: bund = "Nordrhein-Westfalen"; break;
                case > 50101 and <= 51597: bund = "Nordrhein-Westfalen"; break;
                case > 51601 and <= 53359: bund = "Nordrhein-Westfalen"; break;
                case > 53581 and <= 53604: bund = "Nordrhein-Westfalen"; break;
                case > 53621 and <= 53949: bund = "Nordrhein-Westfalen"; break;
                case > 57001 and <= 57489: bund = "Nordrhein-Westfalen"; break;
                case 58119: bund = "Nordrhein-Westfalen"; break;
                case 58135: bund = "Nordrhein-Westfalen"; break;
                case 58089: bund = "Nordrhein-Westfalen"; break;
                case >= 58091 and <= 58099: bund = "Nordrhein-Westfalen"; break;
                case 58300: bund = "Nordrhein-Westfalen"; break;
                case 58239: bund = "Nordrhein-Westfalen"; break;
                case 58256: bund = "Nordrhein-Westfalen"; break;
                case 58285: bund = "Nordrhein-Westfalen"; break;
                case >= 58452 and <= 58454: bund = "Nordrhein-Westfalen"; break;
                case 58332: bund = "Nordrhein-Westfalen"; break;
                case 58339: bund = "Nordrhein-Westfalen"; break;
                case 58313: bund = "Nordrhein-Westfalen"; break;
                case 58456: bund = "Nordrhein-Westfalen"; break;
                case >= 58500 and <= 58599: bund = "Nordrhein-Westfalen"; break;
                case >= 58600 and <=58699: bund = "Nordrhein-Westfalen"; break; 
                case >= 58706 and <= 58791: bund = "Nordrhein-Westfalen"; break;
                case >= 58802 and <= 58849: bund = "Nordrhein-westfalen"; break;
                case 59192: bund = "Nordrhein-Westfalen"; break;
                case >= 59000 and <= 59969: bund = "Nordrhein-Westfalen"; break;
                #endregion
                #region Hessen
                case > 34001 and <= 34329: bund = "Hessen"; break;
                case > 34356 and <= 34399: bund = "Hessen"; break;
                case > 34441 and <= 36399: bund = "Hessen"; break;
                case > 37194 and 37195: bund = "Hessen"; break;
                case > 37201 and <= 37299: bund = "Hessen"; break;
                case > 55240 and <= 55252: bund = "Hessen"; break;
                case > 60001 and <= 63699: bund = "Hessen"; break;
                case 63776: bund = "Hessen"; break;
                case > 64201 and <= 64753: bund = "Hessen"; break;
                case > 64754 and < 65326: bund = "Hessen"; break;
                case > 65327 and < 65391: bund = "Hessen"; break;
                case > 65392 and <= 65556: bund = "Hessen"; break;
                case > 65583 and <= 65620: bund = "Hessen"; break;
                case 65627: bund = "Hessen"; break;
                case > 65701 and <= 65936: bund = "Hessen"; break;
                case > 68501 and <= 68519: bund = "Hessen"; break;
                case > 68601 and <= 68649: bund = "Hessen"; break;
                case > 69235 and <= 69239: bund = "Hessen"; break;
                case > 69430 and 69431: bund = "Hessen"; break;
                case 69434: bund = "Hessen"; break;
                case > 69479 and <= 69488: bund = "Hessen"; break;
                case > 69503 and <= 69509: bund = "Hessen"; break;
                case > 69515 and <= 69518: bund = "Hessen"; break;
                #endregion
                #region Rheinland-Pfalz
                case 51598: bund = "Rheinland-Pfalz"; break;
                case > 53401 and <= 53579: bund = "Rheinland-Pfalz"; break;
                case > 53614 and <= 53619: bund = "Rheinland-Pfalz"; break;
                case > 54181 and <= 55239: bund = "Rheinland-Pfalz"; break;
                case > 55253 and <= 56869: bund = "Rheinland-Pfalz"; break;
                case > 57501 and <= 57648: bund = "Rheinland-Pfalz"; break;
                case 65326: bund = "Rheinland-Pfalz"; break;
                case 65391: bund = "Rheinland-Pfalz"; break;
                case > 65558 and <= 65582: bund = "Rheinland-Pfalz"; break;
                case > 65621 and <= 65626: bund = "Rheinland-Pfalz"; break;
                case 65629: bund = "Rheinland-Pfalz"; break;
                case > 66461 and <= 66509: bund = "Rheinland-Pfalz"; break;
                case > 66841 and <= 67829: bund = "Rheinland-Pfalz"; break;
                case > 76711 and <= 76891: bund = "Rheinland-Pfalz"; break;
                #endregion
                #region Bayern
                case > 63701 and <= 63774: bund = "Bayern"; break;
                case > 63776 and < 63928: bund = "Bayern"; break;
                case > 63930 and <= 63939: bund = "Bayern"; break;
                case 74594: bund = "Bayern"; break;
                case > 80001 and <= 87490: bund = "Bayern"; break;
                case > 87493 and <= 87561: bund = "Bayern"; break;
                case > 87571 and <= 87789: bund = "Bayern"; break;
                case > 88101 and <= 88146: bund = "Bayern"; break;
                case > 88147 and <= 88179: bund = "Bayern"; break;
                case 89081: bund = "Bayern"; break;
                case 89087 : bund = "Bayern"; break;
                case > 89201 and <= 89449: bund = "Bayern"; break;
                case > 90001 and <= 96489: bund = "Bayern"; break;
                case > 97001 and <= 97859: bund = "Bayern"; break;
                case > 97888 and <= 97892: bund = "Bayern"; break;
                case 97896 : bund = "Bayern"; break;
                case > 97901 and <= 97909: bund = "Bayern"; break;
                #endregion
                #region Banden-Württenberg
                case 63928: bund = "Banden-Württenberg"; break;
                case 64754: bund = "Banden-Württenberg"; break;
                case > 68001 and <= 68312: bund = "Banden-Württenberg"; break;
                case > 68520 and <= 68549: bund = "Banden-Württenberg"; break;
                case > 68701 and <= 69234: bund = "Banden-Württenberg"; break;
                case > 69240 and <= 69429: bund = "Banden-Württenberg"; break;
                case > 69435 and <= 69469: bund = "Banden-Württenberg"; break;
                case > 69489 and <= 69502: bund = "Banden-Württenberg"; break;
                case > 69510 and <= 69514: bund = "Banden-Württenberg"; break;
                case > 70001 and <= 74592: bund = "Banden-Württenberg"; break;
                case > 74594 and <= 76709: bund = "Banden-Württenberg"; break;
                case > 77601 and <= 79879: bund = "Banden-Württenberg"; break;
                case > 88001 and <= 88099: bund = "Banden-Württenberg"; break;
                case 88147: bund = "Banden-Württenberg"; break;
                case > 88181 and <= 89079: bund = "Banden-Württenberg"; break;
                case > 89081 and <= 89085: bund = "Banden-Württenberg"; break;
                case > 89090 and <= 89198: bund = "Banden-Württenberg"; break;
                case > 89501 and <= 89619: bund = "Banden-Württenberg"; break;
                case > 97861 and <= 97877: bund = "Banden-Württenberg"; break;
                case > 97893 and <= 97896: bund = "Banden-Württenberg"; break;
                case > 97897 and <= 97900: bund = "Banden-Württenberg"; break;
                case > 97911 and <= 97999: bund = "Banden-Württenberg"; break;
                #endregion
                #region Saarland
                case > 66001 and <= 66459: bund = "Saarland"; break;
                case > 66511 and <= 66839: bund = "Saarland"; break;
                #endregion
                #region Außerhalb der BRD
                case 87491: bund = "Außerhalb der BRD"; break;
                case > 87567 and <= 87569: bund = "Außerhalb der BRD"; break;
                #endregion
                default: break;
            }

            return bund;
            
        }
    }
}
