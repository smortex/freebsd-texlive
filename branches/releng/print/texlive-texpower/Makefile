# New ports collection makefile for:	texlive-texpower
# Date created:		26/01/2009 16:09:38
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texpower
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Create dynamic online presentations with LaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/tpslifonts/tpslifonts.sty:${PORTSDIR}/print/texlive-tpslifonts

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
