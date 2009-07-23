# New ports collection makefile for:	texlive-physe
# Date created:		26/01/2009 16:04:57
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	physe
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The PHYSE format.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.physe.cnf:${PORTSDIR}/print/texlive-bin-physe

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
