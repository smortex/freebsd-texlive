# New ports collection makefile for:	texlive-physe
# Date created:		13/03/2010 04:30:50
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	physe
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The PHYSE format.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
