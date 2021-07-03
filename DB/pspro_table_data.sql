SET IDENTITY_INSERT [dbo].[Personnel] ON 

INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1000, N'Mike', N'Hamel', N'M', CAST(N'1995-01-03' AS Date), CAST(N'1970-03-29' AS Date), N'Administration')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1001, N'Robert', N'Peel', N'M', CAST(N'1892-01-03' AS Date), CAST(N'1845-03-29' AS Date), N'Administration')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1002, N'Wyatt', N'Earp', N'M', CAST(N'1961-03-06' AS Date), CAST(N'1955-05-12' AS Date), N'Patrol')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1003, N'Andy', N'Taylor', N'M', CAST(N'1960-01-12' AS Date), CAST(N'1940-09-25' AS Date), N'Patrol')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1004, N'Rick', N'Grimes', N'M', CAST(N'2010-12-25' AS Date), CAST(N'1985-05-02' AS Date), N'Patrol')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1005, N'Cordell', N'Walker', N'M', CAST(N'1993-05-27' AS Date), CAST(N'1970-05-13' AS Date), N'Investigations')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1006, N'Harry', N'Callahan', N'M', CAST(N'2010-05-17' AS Date), CAST(N'1991-08-25' AS Date), N'Investigations')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1007, N'John', N'McLane', N'M', CAST(N'1998-03-01' AS Date), CAST(N'1974-03-05' AS Date), N'Patrol')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1008, N'Frank', N'Columbo', N'M', CAST(N'1999-01-13' AS Date), CAST(N'1969-04-05' AS Date), N'Traffic')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1009, N'Robo', N'Cop', N'M', CAST(N'1992-03-24' AS Date), CAST(N'1972-04-04' AS Date), N'Patrol')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1010, N'Rosco', N'Coltrane', N'M', CAST(N'1988-04-05' AS Date), CAST(N'1967-02-23' AS Date), N'Patrol')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1011, N'Danny', N'Reagan', N'M', CAST(N'2000-12-12' AS Date), CAST(N'1980-04-23' AS Date), N'Investigations')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1012, N'Joe', N'Friday', N'M', CAST(N'2001-12-23' AS Date), CAST(N'1980-01-23' AS Date), N'Investigations')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1013, N'Kate', N'Beckett', N'F', CAST(N'2010-02-03' AS Date), CAST(N'1989-04-03' AS Date), N'Investigations')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1014, N'Jessica', N'Fletcher', N'F', CAST(N'2010-04-29' AS Date), CAST(N'1988-04-05' AS Date), N'Patrol')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1015, N'Nancy', N'Drew', N'F', CAST(N'2020-04-07' AS Date), CAST(N'1998-07-15' AS Date), N'Investigations')
INSERT [dbo].[Personnel] ([personnel_id], [first_name], [last_name], [gender], [hire_date], [birthdate], [assignment]) VALUES (1016, N'Olivia', N'Benson', N'F', CAST(N'2000-04-19' AS Date), CAST(N'1985-09-17' AS Date), N'Investigations')
SET IDENTITY_INSERT [dbo].[Personnel] OFF
GO
INSERT [dbo].[Administrators] ([personnel_id], [username], [password]) VALUES (1001, N'a-001', N'EPA«_Ç»2-O~Ò }ÞWDo~±¶L{È¡b§Ùˆ¤å–Tûÿ¹µÑ(Ž ëê¡Ëƒ#ÍùËv¿-Ô')
INSERT [dbo].[Administrators] ([personnel_id], [username], [password]) VALUES (1009, N'a-002', N'ØB^v£x¼m*F|sHµD!Ü‰*Wm ¤úh!9C¦Ÿß…eçÃ!×pJWxhÝÑûF›nï›ÞÍòÍ')
INSERT [dbo].[Administrators] ([personnel_id], [username], [password]) VALUES (1015, N'a-003', N'NÒ$,v‚‡êNÃ”P%½Óö‰ïa‚u?£xñetAª¿ÂØÂ¬DÂ—÷X9—î«ëÀU²à÷•àô‘')
GO
INSERT [dbo].[Investigators] ([personnel_id], [username], [password]) VALUES (1005, N'i-001', N'€uõÓÎƒlÌÏ¼F»‰i·rù0ÂbN¡õII`>¹{vË0 ap(7*ÙyÊ—K†í]¹ZÎ¿¯ë5\èpÃw')
INSERT [dbo].[Investigators] ([personnel_id], [username], [password]) VALUES (1006, N'i-002', N'¶}Å÷ÍÎ(Øq~§ð‰qøÍ‚ßu»3­ÝBÀÛ®ð¢ke@›4ÚÉÍoŒ<ÉºQýíæ	f­Qž†åZ¸e')
INSERT [dbo].[Investigators] ([personnel_id], [username], [password]) VALUES (1013, N'i-003', N'_¥Ô¡î:M¼ìÇÖ\¨¡õñN«:×DêËÊ5:jÕP‰U¡¼s¦S€j)œPù@Îm7€†>N¼#‹,8xÕë')
GO
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1001)
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1002)
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1003)
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1004)
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1007)
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1010)
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1012)
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1014)
INSERT [dbo].[Officers] ([personnel_id]) VALUES (1016)
GO
INSERT [dbo].[Supervisors] ([personnel_id], [username], [password]) VALUES (1000, N's-003', N'þÏ³o›O‚ûî˜?Ø
ÂçB”6³A‘š6hb¶ã°m4ð£ôGÙ¦Â‘€ë»¼[<ÀêráNæø¯©t%îv@l')
INSERT [dbo].[Supervisors] ([personnel_id], [username], [password]) VALUES (1008, N's-001', N'p°aZ!ïdòÓ£CÒb ÊN«Žgwî½ 8v•€h,)8A+iëæÖ`
Ú[*’Ãœˆƒºò€ªW¢S…%{&')
INSERT [dbo].[Supervisors] ([personnel_id], [username], [password]) VALUES (1011, N's-002', N'ÀÐào GD‘X‚¾.ö²…ê.û‘Ix,¶7Ë Î‡nk§àh4$¯`ìKù^m×ïaÉqD!L™+aƒ)Ä™2Æ')
GO
SET IDENTITY_INSERT [dbo].[Citizens] ON 

INSERT [dbo].[Citizens] ([citizen_id], [first_name], [last_name], [address1], [address2], [city], [state], [zipcode], [phone], [email]) VALUES (5000, N'Bugs', N'Bunny', N'24 Carrot Lane', NULL, N'Toon Town', N'FL', N'87658', N'555-555-5555', N'bugs@email.com')
INSERT [dbo].[Citizens] ([citizen_id], [first_name], [last_name], [address1], [address2], [city], [state], [zipcode], [phone], [email]) VALUES (5001, N'Mickey', N'Mouse', N'1 Disney Way', NULL, N'Anaheim', N'CA', N'90765', N'555-666-7777', N'mickey@email.com')
INSERT [dbo].[Citizens] ([citizen_id], [first_name], [last_name], [address1], [address2], [city], [state], [zipcode], [phone], [email]) VALUES (5002, N'Daffy', N'Duck', N'5150 Looney Dr.', NULL, N'New York', N'NY', N'87654', N'111-111-1111', NULL)
INSERT [dbo].[Citizens] ([citizen_id], [first_name], [last_name], [address1], [address2], [city], [state], [zipcode], [phone], [email]) VALUES (5003, N'Woody', N'Woodpecker', N'3 Worm Way', NULL, N'Little Rock', N'AR', N'55567', N'888-888-8888', N'woody@email.com')
INSERT [dbo].[Citizens] ([citizen_id], [first_name], [last_name], [address1], [address2], [city], [state], [zipcode], [phone], [email]) VALUES (5004, N'Bart', N'Simpson', N'742 Evergreen Terrace', NULL, N'Springfield', N'OR', N'87687', N'444-444-4444', NULL)
SET IDENTITY_INSERT [dbo].[Citizens] OFF
GO


INSERT [dbo].[Complaints] ([citizen_id], [officers_personnel_id], [supervisors_personnel_id], [investigators_personnel_id], [administrators_personnel_id], [date_created], [allegation_type], [complaint_notes], [disposition], [disposition_date], [discipline]) VALUES (5002, 1002, 1008, NULL, NULL, CAST(N'2021-06-16T17:06:41.220' AS DateTime), N'Excessive Force', N'6/16/2021 10:06:40 AM by Frank Columbo: Shot me in the face', NULL, NULL, NULL)
INSERT [dbo].[Complaints] ([citizen_id], [officers_personnel_id], [supervisors_personnel_id], [investigators_personnel_id], [administrators_personnel_id], [date_created], [allegation_type], [complaint_notes], [disposition], [disposition_date], [discipline]) VALUES (5004, 1003, 1008, NULL, NULL, CAST(N'2020-06-16T17:09:01.497' AS DateTime), N'Courtesy Complaint', N'6/16/2021 10:09:00 AM by Frank Columbo: Was rude to me', NULL, NULL, NULL)
INSERT [dbo].[Complaints] ([citizen_id], [officers_personnel_id], [supervisors_personnel_id], [investigators_personnel_id], [administrators_personnel_id], [date_created], [allegation_type], [complaint_notes], [disposition], [disposition_date], [discipline]) VALUES (5003, 1016, 1008, NULL, NULL, CAST(N'2019-06-16T17:09:28.840' AS DateTime), N'Ethics Violation', N'6/16/2021 10:09:27 AM by Frank Columbo: Stole my birdseed', NULL, NULL, NULL)
INSERT [dbo].[Complaints] ([citizen_id], [officers_personnel_id], [supervisors_personnel_id], [investigators_personnel_id], [administrators_personnel_id], [date_created], [allegation_type], [complaint_notes], [disposition], [disposition_date], [discipline]) VALUES (5003, 1016, 1008, NULL, NULL, CAST(N'2019-06-16T17:09:28.840' AS DateTime), N'Ethics Violation', N'6/16/2021 10:09:27 AM by Frank Columbo: Stole my birdseed', NULL, NULL, NULL)
INSERT [dbo].[Complaints] ([citizen_id], [officers_personnel_id], [supervisors_personnel_id], [investigators_personnel_id], [administrators_personnel_id], [date_created], [allegation_type], [complaint_notes], [disposition], [disposition_date], [discipline]) VALUES (5003, 1016, 1008, NULL, NULL, CAST(N'2019-06-16T17:09:28.840' AS DateTime), N'Ethics Violation', N'6/16/2021 10:09:27 AM by Frank Columbo: Stole my birdseed', NULL, NULL, NULL)
INSERT [dbo].[Complaints] ([citizen_id], [officers_personnel_id], [supervisors_personnel_id], [investigators_personnel_id], [administrators_personnel_id], [date_created], [allegation_type], [complaint_notes], [disposition], [disposition_date], [discipline]) VALUES (5001, 1002, 1008, NULL, NULL, CAST(N'2018-06-16T17:10:13.543' AS DateTime), N'Conduct Unbecoming', N'6/16/2021 10:10:12 AM by Frank Columbo: Made fun of my big ears', NULL, NULL, NULL)
INSERT [dbo].[Complaints] ([citizen_id], [officers_personnel_id], [supervisors_personnel_id], [investigators_personnel_id], [administrators_personnel_id], [date_created], [allegation_type], [complaint_notes], [disposition], [disposition_date], [discipline]) VALUES (5002, 1014, 1008, NULL, NULL, CAST(N'2017-06-16T17:10:55.590' AS DateTime), N'Dangerous Driving', N'6/16/2021 10:10:54 AM by Frank Columbo: Drove faster than I can fly in traffic!', NULL, NULL, NULL)
GO

