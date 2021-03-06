USE [sgps]
GO
/****** Object:  Table [dbo].[atendimento]    Script Date: 11/21/2012 22:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[atendimento](
	[idAtendimento] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NOT NULL,
	[strMotivoAtendimento] [varchar](200) NOT NULL,
	[strProvidencias] [varchar](200) NOT NULL,
	[idMaterial] [int] NOT NULL,
	[dtmDataAtendimento] [date] NOT NULL,
	[idMaterialAtendimento] [int] NOT NULL,
 CONSTRAINT [PK_atendimento] PRIMARY KEY CLUSTERED 
(
	[idAtendimento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[materialAtendimento]    Script Date: 11/21/2012 22:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[materialAtendimento](
	[idMaterial] [int] IDENTITY(1,1) NOT NULL,
	[strDesMat] [varchar](30) NOT NULL,
	[strQtdMat] [nchar](10) NOT NULL,
 CONSTRAINT [PK_materialAtendimento] PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[material]    Script Date: 11/21/2012 22:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[material](
	[idMaterial] [int] IDENTITY(1,1) NOT NULL,
	[strDesMat] [varchar](30) NOT NULL,
	[strQtdMat] [nchar](10) NOT NULL,
 CONSTRAINT [PK_material] PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hospital]    Script Date: 11/21/2012 22:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hospital](
	[idHospital] [int] IDENTITY(1,1) NOT NULL,
	[strRazaoSocial] [varchar](100) NOT NULL,
	[strCNPJ] [nchar](20) NOT NULL,
	[strEndereco] [varchar](200) NOT NULL,
	[strTelefone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_hospital] PRIMARY KEY CLUSTERED 
(
	[idHospital] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[profissional]    Script Date: 11/21/2012 22:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[profissional](
	[strNome] [varchar](50) NOT NULL,
	[strCPF] [nchar](11) NOT NULL,
	[strCargo] [nchar](10) NOT NULL,
	[dtmHorario] [datetime] NOT NULL,
	[strEscala] [varchar](50) NOT NULL,
	[idProfissional] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_profissional] PRIMARY KEY CLUSTERED 
(
	[idProfissional] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[paciente]    Script Date: 11/21/2012 22:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[paciente](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[strNome] [varchar](100) NOT NULL,
	[strCategoria] [varchar](50) NOT NULL,
	[strDataDeNascimento] [varchar](50) NOT NULL,
	[strCpf] [varchar](11) NOT NULL,
	[strEndereco] [varchar](200) NOT NULL,
	[strTelefone] [nchar](10) NOT NULL,
 CONSTRAINT [PK_paciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[movimentacaoEstoque]    Script Date: 11/21/2012 22:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[movimentacaoEstoque](
	[idMovMat] [int] IDENTITY(1,1) NOT NULL,
	[strDesMov] [varchar](30) NOT NULL,
	[dtmDatMov] [date] NOT NULL,
	[strQtdMov] [nchar](10) NOT NULL,
	[idMaterial] [int] NOT NULL,
 CONSTRAINT [PK_movimentacaoEstoque] PRIMARY KEY CLUSTERED 
(
	[idMovMat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[encaminhamento]    Script Date: 11/21/2012 22:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[encaminhamento](
	[idEncaminhamento] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NOT NULL,
	[idHospital] [int] NOT NULL,
	[strMotivo] [varchar](50) NOT NULL,
	[strSituacaoAtual] [varchar](50) NOT NULL,
	[dtmDataEncaminhamento] [date] NOT NULL,
 CONSTRAINT [PK_encaminhamento] PRIMARY KEY CLUSTERED 
(
	[idEncaminhamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_atendimento_idMaterialAtendimento]    Script Date: 11/21/2012 22:54:31 ******/
ALTER TABLE [dbo].[atendimento] ADD  CONSTRAINT [DF_atendimento_idMaterialAtendimento]  DEFAULT ((0)) FOR [idMaterialAtendimento]
GO
/****** Object:  ForeignKey [FK_encaminhamento_hospital]    Script Date: 11/21/2012 22:54:31 ******/
ALTER TABLE [dbo].[encaminhamento]  WITH CHECK ADD  CONSTRAINT [FK_encaminhamento_hospital] FOREIGN KEY([idHospital])
REFERENCES [dbo].[hospital] ([idHospital])
GO
ALTER TABLE [dbo].[encaminhamento] CHECK CONSTRAINT [FK_encaminhamento_hospital]
GO
/****** Object:  ForeignKey [FK_encaminhamento_paciente]    Script Date: 11/21/2012 22:54:31 ******/
ALTER TABLE [dbo].[encaminhamento]  WITH CHECK ADD  CONSTRAINT [FK_encaminhamento_paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[encaminhamento] CHECK CONSTRAINT [FK_encaminhamento_paciente]
GO
/****** Object:  ForeignKey [FK_movimentacaoEstoque_material]    Script Date: 11/21/2012 22:54:31 ******/
ALTER TABLE [dbo].[movimentacaoEstoque]  WITH CHECK ADD  CONSTRAINT [FK_movimentacaoEstoque_material] FOREIGN KEY([idMaterial])
REFERENCES [dbo].[material] ([idMaterial])
GO
ALTER TABLE [dbo].[movimentacaoEstoque] CHECK CONSTRAINT [FK_movimentacaoEstoque_material]
GO
