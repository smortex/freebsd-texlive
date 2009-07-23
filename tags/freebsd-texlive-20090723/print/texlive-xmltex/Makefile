# New ports collection makefile for:	texlive-xmltex
# Date created:		26/01/2009 16:05:22
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	xmltex
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Support for parsing XML documents.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.xmltex.cnf:${PORTSDIR}/print/texlive-bin-xmltex

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
