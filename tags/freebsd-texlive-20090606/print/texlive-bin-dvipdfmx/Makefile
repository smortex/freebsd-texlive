# New ports collection makefile for:	texlive-bin-dvipdfmx
# Date created:		26/01/2009 16:02:47
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-dvipdfmx
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	An extended version of dvipdfm.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
