# New ports collection makefile for:	texlive-lh
# Date created:		26/01/2009 16:05:57
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	lh
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	CyrTUG Cyrillic alphabet fonts ("LH") with support of LaTeX standard encodings.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/source/jknappen/ec/ecbi.mf:${PORTSDIR}/print/texlive-ec

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
