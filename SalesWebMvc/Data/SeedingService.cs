using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //Banco de dados populado
            }

            Department d1 = new Department(1, "Informática");
            Department d2 = new Department(2, "Electronicos");
            Department d3 = new Department(3, "Ferramentas");
            Department d4 = new Department(4, "Livros");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 2000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 01, 25), 10200.0, SaleStatus.Faturado, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 01, 4), 7000.0, SaleStatus.Faturado, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 01, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 01, 1), 8000.0, SaleStatus.Faturado, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 01, 21), 3000.0, SaleStatus.Faturado, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 01, 15), 2000.0, SaleStatus.Faturado, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 01, 28), 13000.0, SaleStatus.Faturado, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 01, 11), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 01, 14), 10200.0, SaleStatus.Pendente, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 01, 7), 9000.0, SaleStatus.Faturado, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 01, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 01, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 01, 29), 02000.0, SaleStatus.Faturado, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2021, 01, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 01, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2021, 02, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2021, 02, 1), 12000.0, SaleStatus.Faturado, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2021, 02, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2021, 02, 22), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2021, 02, 15), 8000.0, SaleStatus.Faturado, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2021, 02, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2021, 02, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 02, 19), 10200.0, SaleStatus.Cancelado, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2021, 02, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2021, 02, 27), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2021, 02, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2021, 02, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2021, 02, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2021, 02, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2021, 02, 12), 5000.0, SaleStatus.Faturado, s2);
            SalesRecord r31 = new SalesRecord(31, new DateTime(2021, 03, 25), 10200.0, SaleStatus.Faturado, s1);
            SalesRecord r32 = new SalesRecord(32, new DateTime(2021, 03, 4), 7000.0, SaleStatus.Faturado, s5);
            SalesRecord r33 = new SalesRecord(33, new DateTime(2021, 03, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r34 = new SalesRecord(34, new DateTime(2021, 03, 1), 8000.0, SaleStatus.Faturado, s1);
            SalesRecord r35 = new SalesRecord(35, new DateTime(2021, 03, 21), 3000.0, SaleStatus.Faturado, s3);
            SalesRecord r36 = new SalesRecord(36, new DateTime(2021, 03, 15), 2000.0, SaleStatus.Faturado, s1);
            SalesRecord r37 = new SalesRecord(37, new DateTime(2021, 03, 28), 13000.0, SaleStatus.Faturado, s2);
            SalesRecord r38 = new SalesRecord(38, new DateTime(2021, 03, 11), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r39 = new SalesRecord(39, new DateTime(2021, 03, 14), 10200.0, SaleStatus.Pendente, s6);
            SalesRecord r40 = new SalesRecord(40, new DateTime(2021, 03, 7), 9000.0, SaleStatus.Faturado, s6);
            SalesRecord r41 = new SalesRecord(41, new DateTime(2021, 03, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r42 = new SalesRecord(42, new DateTime(2021, 03, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r43 = new SalesRecord(43, new DateTime(2021, 04, 29), 02000.0, SaleStatus.Faturado, s4);
            SalesRecord r44 = new SalesRecord(44, new DateTime(2021, 04, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r45 = new SalesRecord(45, new DateTime(2021, 04, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r46 = new SalesRecord(46, new DateTime(2021, 04, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r47 = new SalesRecord(47, new DateTime(2021, 04, 1), 12000.0, SaleStatus.Faturado, s1);
            SalesRecord r48 = new SalesRecord(48, new DateTime(2021, 04, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r49 = new SalesRecord(49, new DateTime(2021, 04, 22), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r50 = new SalesRecord(50, new DateTime(2021, 04, 15), 8000.0, SaleStatus.Faturado, s6);
            SalesRecord r51 = new SalesRecord(51, new DateTime(2021, 04, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r52 = new SalesRecord(52, new DateTime(2021, 04, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r53 = new SalesRecord(53, new DateTime(2021, 04, 19), 10200.0, SaleStatus.Cancelado, s2);
            SalesRecord r54 = new SalesRecord(54, new DateTime(2021, 04, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r55 = new SalesRecord(55, new DateTime(2021, 04, 27), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r56 = new SalesRecord(56, new DateTime(2021, 04, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r57 = new SalesRecord(57, new DateTime(2021, 04, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r58 = new SalesRecord(58, new DateTime(2021, 04, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r59 = new SalesRecord(59, new DateTime(2021, 04, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r60 = new SalesRecord(60, new DateTime(2021, 04, 12), 5000.0, SaleStatus.Faturado, s2);
            SalesRecord r61 = new SalesRecord(61, new DateTime(2021, 05, 25), 10200.0, SaleStatus.Faturado, s1);
            SalesRecord r62 = new SalesRecord(62, new DateTime(2021, 05, 4), 7000.0, SaleStatus.Faturado, s5);
            SalesRecord r63 = new SalesRecord(63, new DateTime(2021, 05, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r64 = new SalesRecord(64, new DateTime(2021, 05, 1), 8000.0, SaleStatus.Faturado, s1);
            SalesRecord r65 = new SalesRecord(65, new DateTime(2021, 05, 21), 3000.0, SaleStatus.Faturado, s3);
            SalesRecord r66 = new SalesRecord(66, new DateTime(2021, 05, 15), 2000.0, SaleStatus.Faturado, s1);
            SalesRecord r67 = new SalesRecord(67, new DateTime(2021, 05, 28), 13000.0, SaleStatus.Faturado, s2);
            SalesRecord r68 = new SalesRecord(68, new DateTime(2021, 05, 11), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r69 = new SalesRecord(69, new DateTime(2021, 05, 14), 10200.0, SaleStatus.Pendente, s6);
            SalesRecord r70 = new SalesRecord(70, new DateTime(2021, 05, 7), 9000.0, SaleStatus.Faturado, s6);
            SalesRecord r71 = new SalesRecord(71, new DateTime(2021, 05, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r72 = new SalesRecord(72, new DateTime(2021, 05, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r73 = new SalesRecord(73, new DateTime(2021, 05, 29), 02000.0, SaleStatus.Faturado, s4);
            SalesRecord r74 = new SalesRecord(74, new DateTime(2021, 05, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r75 = new SalesRecord(75, new DateTime(2021, 05, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r76 = new SalesRecord(76, new DateTime(2021, 05, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r77 = new SalesRecord(77, new DateTime(2021, 05, 1), 12000.0, SaleStatus.Faturado, s1);
            SalesRecord r78 = new SalesRecord(78, new DateTime(2021, 05, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r79 = new SalesRecord(79, new DateTime(2021, 05, 22), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r80 = new SalesRecord(80, new DateTime(2021, 05, 15), 8000.0, SaleStatus.Faturado, s6);
            SalesRecord r81 = new SalesRecord(81, new DateTime(2021, 05, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r82 = new SalesRecord(82, new DateTime(2021, 05, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r83 = new SalesRecord(83, new DateTime(2021, 05, 19), 10200.0, SaleStatus.Cancelado, s2);
            SalesRecord r84 = new SalesRecord(84, new DateTime(2021, 05, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r85 = new SalesRecord(85, new DateTime(2021, 06, 27), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r86 = new SalesRecord(86, new DateTime(2021, 06, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r87 = new SalesRecord(87, new DateTime(2021, 06, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r88 = new SalesRecord(88, new DateTime(2021, 06, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r89 = new SalesRecord(89, new DateTime(2021, 06, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r90 = new SalesRecord(90, new DateTime(2021, 06, 12), 5000.0, SaleStatus.Faturado, s2);
            SalesRecord r91 = new SalesRecord(91, new DateTime(2021, 06, 25), 10200.0, SaleStatus.Faturado, s1);
            SalesRecord r92 = new SalesRecord(92, new DateTime(2021, 06, 4), 7000.0, SaleStatus.Faturado, s5);
            SalesRecord r93 = new SalesRecord(93, new DateTime(2021, 06, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r94 = new SalesRecord(94, new DateTime(2021, 06, 1), 8000.0, SaleStatus.Faturado, s1);
            SalesRecord r95 = new SalesRecord(95, new DateTime(2021, 06, 21), 3000.0, SaleStatus.Faturado, s3);
            SalesRecord r96 = new SalesRecord(96, new DateTime(2021, 06, 15), 2000.0, SaleStatus.Faturado, s1);
            SalesRecord r97 = new SalesRecord(97, new DateTime(2021, 06, 28), 13000.0, SaleStatus.Faturado, s2);
            SalesRecord r98 = new SalesRecord(98, new DateTime(2021, 06, 11), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r99 = new SalesRecord(99, new DateTime(2021, 06, 14), 10200.0, SaleStatus.Pendente, s6);
            SalesRecord r100 = new SalesRecord(100, new DateTime(2021, 07, 7), 9000.0, SaleStatus.Faturado, s6);
            SalesRecord r101 = new SalesRecord(101, new DateTime(2021, 07, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r102 = new SalesRecord(102, new DateTime(2021, 07, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r103 = new SalesRecord(103, new DateTime(2021, 07, 29), 02000.0, SaleStatus.Faturado, s4);
            SalesRecord r104 = new SalesRecord(104, new DateTime(2021, 07, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r105 = new SalesRecord(105, new DateTime(2021, 07, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r106 = new SalesRecord(106, new DateTime(2021, 07, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r107 = new SalesRecord(107, new DateTime(2021, 07, 1), 12000.0, SaleStatus.Faturado, s1);
            SalesRecord r108 = new SalesRecord(108, new DateTime(2021, 07, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r109 = new SalesRecord(109, new DateTime(2021, 07, 22), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r110 = new SalesRecord(110, new DateTime(2021, 07, 15), 8000.0, SaleStatus.Faturado, s6);
            SalesRecord r111 = new SalesRecord(111, new DateTime(2021, 07, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r112 = new SalesRecord(112, new DateTime(2021, 07, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r113 = new SalesRecord(113, new DateTime(2021, 07, 19), 10200.0, SaleStatus.Cancelado, s2);
            SalesRecord r114 = new SalesRecord(114, new DateTime(2021, 07, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r115 = new SalesRecord(115, new DateTime(2021, 08, 27), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r116 = new SalesRecord(116, new DateTime(2021, 08, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r117 = new SalesRecord(117, new DateTime(2021, 08, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r118 = new SalesRecord(118, new DateTime(2021, 08, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r119 = new SalesRecord(119, new DateTime(2021, 08, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r120 = new SalesRecord(120, new DateTime(2021, 08, 12), 5000.0, SaleStatus.Faturado, s2);
            SalesRecord r121 = new SalesRecord(121, new DateTime(2021, 08, 25), 10200.0, SaleStatus.Faturado, s1);
            SalesRecord r122 = new SalesRecord(122, new DateTime(2021, 08, 4), 7000.0, SaleStatus.Faturado, s5);
            SalesRecord r123 = new SalesRecord(123, new DateTime(2021, 08, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r124 = new SalesRecord(124, new DateTime(2021, 08, 1), 8000.0, SaleStatus.Faturado, s1);
            SalesRecord r125 = new SalesRecord(125, new DateTime(2021, 08, 21), 3000.0, SaleStatus.Faturado, s3);
            SalesRecord r126 = new SalesRecord(126, new DateTime(2021, 08, 15), 2000.0, SaleStatus.Faturado, s1);
            SalesRecord r127 = new SalesRecord(127, new DateTime(2021, 08, 28), 13000.0, SaleStatus.Faturado, s2);
            SalesRecord r128 = new SalesRecord(128, new DateTime(2021, 08, 11), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r129 = new SalesRecord(129, new DateTime(2021, 08, 14), 10200.0, SaleStatus.Pendente, s6);
            SalesRecord r130 = new SalesRecord(130, new DateTime(2021, 08, 7), 9000.0, SaleStatus.Faturado, s6);
            SalesRecord r131 = new SalesRecord(131, new DateTime(2021, 08, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r132 = new SalesRecord(132, new DateTime(2021, 09, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r133 = new SalesRecord(133, new DateTime(2021, 09, 29), 02000.0, SaleStatus.Faturado, s4);
            SalesRecord r134 = new SalesRecord(134, new DateTime(2021, 09, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r135 = new SalesRecord(135, new DateTime(2021, 09, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r136 = new SalesRecord(136, new DateTime(2021, 09, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r137 = new SalesRecord(137, new DateTime(2021, 09, 1), 12000.0, SaleStatus.Faturado, s1);
            SalesRecord r138 = new SalesRecord(138, new DateTime(2021, 09, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r139 = new SalesRecord(139, new DateTime(2021, 09, 22), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r140 = new SalesRecord(140, new DateTime(2021, 09, 15), 8000.0, SaleStatus.Faturado, s6);
            SalesRecord r141 = new SalesRecord(141, new DateTime(2021, 09, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r142 = new SalesRecord(142, new DateTime(2021, 09, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r143 = new SalesRecord(143, new DateTime(2021, 09, 19), 10200.0, SaleStatus.Cancelado, s2);
            SalesRecord r144 = new SalesRecord(144, new DateTime(2021, 09, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r145 = new SalesRecord(145, new DateTime(2021, 09, 27), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r146 = new SalesRecord(146, new DateTime(2021, 09, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r147 = new SalesRecord(147, new DateTime(2021, 09, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r148 = new SalesRecord(148, new DateTime(2021, 09, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r149 = new SalesRecord(149, new DateTime(2021, 09, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r150 = new SalesRecord(150, new DateTime(2021, 09, 12), 5000.0, SaleStatus.Faturado, s2);
            SalesRecord r151 = new SalesRecord(151, new DateTime(2021, 10, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r152 = new SalesRecord(152, new DateTime(2021, 10, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r153 = new SalesRecord(153, new DateTime(2021, 10, 29), 02000.0, SaleStatus.Faturado, s4);
            SalesRecord r154 = new SalesRecord(154, new DateTime(2021, 10, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r155 = new SalesRecord(155, new DateTime(2021, 10, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r156 = new SalesRecord(156, new DateTime(2021, 10, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r157 = new SalesRecord(157, new DateTime(2021, 10, 1), 12000.0, SaleStatus.Faturado, s1);
            SalesRecord r158 = new SalesRecord(158, new DateTime(2021, 10, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r159 = new SalesRecord(159, new DateTime(2021, 10, 22), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r160 = new SalesRecord(160, new DateTime(2021, 10, 15), 8000.0, SaleStatus.Faturado, s6);
            SalesRecord r161 = new SalesRecord(161, new DateTime(2021, 10, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r162 = new SalesRecord(162, new DateTime(2021, 10, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r163 = new SalesRecord(163, new DateTime(2021, 10, 19), 10200.0, SaleStatus.Cancelado, s2);
            SalesRecord r164 = new SalesRecord(164, new DateTime(2021, 10, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r165 = new SalesRecord(165, new DateTime(2021, 10, 27), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r166 = new SalesRecord(166, new DateTime(2021, 10, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r167 = new SalesRecord(167, new DateTime(2021, 10, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r168 = new SalesRecord(168, new DateTime(2021, 10, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r169 = new SalesRecord(169, new DateTime(2021, 11, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r170 = new SalesRecord(170, new DateTime(2021, 11, 12), 5000.0, SaleStatus.Faturado, s2);
            SalesRecord r171 = new SalesRecord(171, new DateTime(2021, 11, 25), 10200.0, SaleStatus.Faturado, s1);
            SalesRecord r172 = new SalesRecord(172, new DateTime(2021, 11, 4), 7000.0, SaleStatus.Faturado, s5);
            SalesRecord r173 = new SalesRecord(173, new DateTime(2021, 11, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r174 = new SalesRecord(174, new DateTime(2021, 11, 1), 8000.0, SaleStatus.Faturado, s1);
            SalesRecord r175 = new SalesRecord(175, new DateTime(2021, 11, 21), 3000.0, SaleStatus.Faturado, s3);
            SalesRecord r176 = new SalesRecord(176, new DateTime(2021, 11, 15), 2000.0, SaleStatus.Faturado, s1);
            SalesRecord r177 = new SalesRecord(177, new DateTime(2021, 11, 28), 13000.0, SaleStatus.Faturado, s2);
            SalesRecord r178 = new SalesRecord(178, new DateTime(2021, 11, 11), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r179 = new SalesRecord(179, new DateTime(2021, 11, 14), 10200.0, SaleStatus.Pendente, s6);
            SalesRecord r180 = new SalesRecord(180, new DateTime(2021, 11, 7), 9000.0, SaleStatus.Faturado, s6);
            SalesRecord r181 = new SalesRecord(181, new DateTime(2021, 11, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r182 = new SalesRecord(182, new DateTime(2021, 11, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r183 = new SalesRecord(183, new DateTime(2021, 11, 29), 02000.0, SaleStatus.Faturado, s4);
            SalesRecord r184 = new SalesRecord(184, new DateTime(2021, 12, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r185 = new SalesRecord(185, new DateTime(2021, 12, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r186 = new SalesRecord(186, new DateTime(2021, 12, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r187 = new SalesRecord(187, new DateTime(2021, 12, 1), 12000.0, SaleStatus.Faturado, s1);
            SalesRecord r188 = new SalesRecord(188, new DateTime(2021, 12, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r189 = new SalesRecord(189, new DateTime(2021, 12, 22), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r190 = new SalesRecord(190, new DateTime(2021, 12, 15), 8000.0, SaleStatus.Faturado, s6);
            SalesRecord r191 = new SalesRecord(191, new DateTime(2021, 12, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r192 = new SalesRecord(192, new DateTime(2021, 12, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r193 = new SalesRecord(193, new DateTime(2021, 12, 19), 10200.0, SaleStatus.Cancelado, s2);
            SalesRecord r194 = new SalesRecord(194, new DateTime(2021, 12, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r195 = new SalesRecord(195, new DateTime(2021, 12, 27), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r196 = new SalesRecord(196, new DateTime(2021, 12, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r197 = new SalesRecord(197, new DateTime(2021, 12, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r198 = new SalesRecord(198, new DateTime(2021, 12, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r199 = new SalesRecord(199, new DateTime(2021, 12, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r200 = new SalesRecord(200, new DateTime(2021, 12, 12), 5000.0, SaleStatus.Faturado, s2);


            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                r31, r32, r33, r34, r35, r36, r37, r38, r39, r40,
                r41, r42, r43, r44, r45, r46, r47, r48, r49, r50,
                r51, r52, r53, r54, r55, r56, r57, r58, r59, r60,
                r61, r62, r63, r64, r65, r66, r67, r68, r69, r70,
                r71, r72, r73, r74, r75, r76, r77, r78, r79, r80,
                r81, r82, r83, r84, r85, r86, r87, r88, r89, r90,
                r91, r92, r93, r94, r95, r96, r97, r98, r99, r100,
                r101, r102, r103, r104, r105, r106, r107, r108, r109,
                r110, r111, r112, r113, r114, r115, r116, r117, r118,
                r119, r120, r121, r122, r123, r124, r125, r126, r127, 
                r128, r129, r130, r131, r132, r133, r134, r135, r136, 
                r137, r138, r139, r140, r141, r142, r143, r144, r145, 
                r146, r147, r148, r149, r150, r151, r152, r153, r154, 
                r155, r156, r157, r158, r159, r160, r161, r162, r163, 
                r164, r165, r166, r167, r168, r169, r170, r171, r172, 
                r173, r174, r175, r176, r177, r178, r179, r180, r181,
                r182, r183, r184, r185, r186, r187, r188, r189, r190,
                r191, r192, r193, r194, r195, r196, r197, r198, r199, r200
            );

            _context.SaveChanges();
        }
    }
}
