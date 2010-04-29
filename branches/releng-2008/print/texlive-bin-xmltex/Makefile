# New ports collection makefile for:	texlive-bin-xmltex
# Date created:		26/01/2009 16:05:22
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-xmltex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Support for parsing XML documents.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.pdftex.cnf:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
