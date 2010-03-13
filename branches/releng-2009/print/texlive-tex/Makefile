# New ports collection makefile for:	texlive-tex
# Date created:		13/03/2010 04:19:57
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	tex
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	A sophisticated typesetting engine.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
