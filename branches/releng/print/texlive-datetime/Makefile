# New ports collection makefile for:	texlive-datetime
# Date created:		26/01/2009 16:07:16
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	datetime
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Change format of \today with commands for current time.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/fmtcount/fmtcount.sty:${PORTSDIR}/print/texlive-fmtcount

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
