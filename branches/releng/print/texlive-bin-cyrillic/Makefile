# New ports collection makefile for:	texlive-bin-cyrillic
# Date created:		26/01/2009 16:05:59
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-cyrillic
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Support for Cyrillic fonts in LaTeX.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
